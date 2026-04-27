import { PASS_MARKS } from "./constants";
export function getGrade(marks) {
    if (marks >= 75)
        return "A";
    if (marks >= 60)
        return "B";
    if (marks >= PASS_MARKS)
        return "C";
    return "Fail";
}
export function getTopper(students) {
    return students.reduce((top, curr) => curr.marks > top.marks ? curr : top);
}
