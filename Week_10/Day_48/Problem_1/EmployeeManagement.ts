// Base Class
class Employee {
  public id: number;
  protected name: string;
  private salary: number;

  constructor(id: number, name: string, salary: number) {
    this.id = id;
    this.name = name;
    this.salary = salary;
  }

  // Getter
  getSalary(): number {
    return this.salary;
  }

  // Setter
  setSalary(value: number): void {
    if (value > 0) {
      this.salary = value;
    } else {
      console.log("Salary must be greater than 0");
    }
  }

  displayDetails(): void {
    console.log(`ID: ${this.id}, Name: ${this.name}, Salary: ${this.salary}`);
  }
}

// Derived Class
class Manager extends Employee {
  teamSize: number;

  constructor(id: number, name: string, salary: number, teamSize: number) {
    super(id, name, salary);
    this.teamSize = teamSize;
  }

  // Method Overriding
  displayDetails(): void {
    console.log(`Manager ID: ${this.id}, Name: ${this.name}, Team Size: ${this.teamSize}`);
  }
}

// Object Creation
const emp = new Employee(1, "Bhavana", 30000);
emp.displayDetails();
emp.setSalary(35000);
console.log("Updated Salary:", emp.getSalary());

const mgr = new Manager(2, "Ravi", 50000, 10);
mgr.displayDetails();