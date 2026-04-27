import { formatName, calculateAverage } from "./utils.js";
import { getGrade, getTopper } from "./student.service.js";
const students = [
    { id: 1, name: "bhavana", marks: 85 },
    { id: 2, name: "rahul", marks: 65 },
    { id: 3, name: "sita", marks: 92 }
];
// Format names
students.forEach(s => {
    console.log("Formatted Name:", formatName(s.name));
});
// Grades
students.forEach(s => {
    console.log(`${s.name} Grade:`, getGrade(s.marks));
});
// Average
console.log("Average Marks:", calculateAverage(students));
// Topper
console.log("Topper:", getTopper(students));
