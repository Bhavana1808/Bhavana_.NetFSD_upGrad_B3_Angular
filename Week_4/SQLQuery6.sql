CREATE DATABASE OnlineStore;
USE OnlineStore;


-- Products Table
CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(50),
    stock_qty INT
);

-- Orders Table
CREATE TABLE orders (
    order_id INT PRIMARY KEY,
    order_date DATE,
    order_status INT
);

-- Order Items Table
CREATE TABLE order_items (
    order_item_id INT PRIMARY KEY,
    order_id INT,
    product_id INT,
    quantity INT,
    FOREIGN KEY (order_id) REFERENCES orders(order_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id)
);

INSERT INTO products VALUES
(1,'Laptop',10),
(2,'Mobile',20),
(3,'Headphones',15);

SELECT * FROM products;
--Create Trigger (Reduce Stock Automatically)

CREATE TRIGGER trg_reduce_stock
ON order_items
AFTER INSERT
AS
BEGIN

IF EXISTS (
SELECT 1
FROM products p
JOIN inserted i
ON p.product_id = i.product_id
WHERE p.stock_qty < i.quantity
)

BEGIN
RAISERROR ('Stock not sufficient',16,1)
ROLLBACK TRANSACTION
RETURN
END

UPDATE p
SET p.stock_qty = p.stock_qty - i.quantity
FROM products p
JOIN inserted i
ON p.product_id = i.product_id

END;

--Transaction to Place Order

BEGIN TRANSACTION

BEGIN TRY

INSERT INTO orders VALUES (1,GETDATE(),1)

INSERT INTO order_items VALUES (101,1,1,2)

COMMIT TRANSACTION

PRINT 'Order placed successfully'

END TRY

BEGIN CATCH

ROLLBACK TRANSACTION

PRINT 'Order failed'

END CATCH

SELECT * FROM products;
SELECT * FROM orders;
SELECT * FROM order_items;

--Transaction for Order Cancellation (SAVEPOINT)

BEGIN TRANSACTION

BEGIN TRY

SAVE TRANSACTION before_restore

UPDATE p
SET p.stock_qty = p.stock_qty + oi.quantity
FROM products p
JOIN order_items oi
ON p.product_id = oi.product_id
WHERE oi.order_id = 1

UPDATE orders
SET order_status = 3
WHERE order_id = 1

COMMIT TRANSACTION

PRINT 'Order cancelled successfully'

END TRY

BEGIN CATCH

ROLLBACK TRANSACTION before_restore

PRINT 'Stock restoration failed'

ROLLBACK TRANSACTION

END CATCH

SELECT * FROM products;
SELECT * FROM orders;
SELECT * FROM order_items;