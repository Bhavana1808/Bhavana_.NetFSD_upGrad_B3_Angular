// 1. Variable Declaration
const userName: string = "Bhavana";
let age: number = 22;
const email: string = "bhavana@example.com";
const isSubscribed: boolean = true;

// 2. Type Inference
let city = "Vijayawada"; // inferred as string
let score = 100; // inferred as number

// 3. Update age using let
age = age + 1;

// 4. Template Literal
const message = `Hello ${userName}, you are ${age} years old and your email is ${email}`;

// 5. Operators
const isEligible = age > 18 && isSubscribed;

// 6. Output
console.log(message);
console.log("City:", city);
console.log("Score:", score);
console.log("Eligible for Premium:", isEligible);