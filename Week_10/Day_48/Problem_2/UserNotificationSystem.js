"use strict";
// 1. Required Parameter
function getWelcomeMessage(name) {
    return `Welcome, ${name}!`;
}
// 2. Optional Parameter
function getUserInfo(name, age) {
    if (age) {
        return `${name} is ${age} years old`;
    }
    return `${name} age not provided`;
}
// 3. Default Parameter
function getSubscriptionStatus(name, isSubscribed = false) {
    return isSubscribed
        ? `${name} is subscribed`
        : `${name} is not subscribed`;
}
// 4. Boolean Return
function isEligibleForPremium(age) {
    return age > 18;
}
// 5. Arrow Function
const getAlertMessage = (msg) => {
    return `Alert: ${msg}`;
};
// 6. Lexical this
const NotificationService = {
    appName: "MyApp",
    sendNotification: (user) => {
        return `Hello ${user}, welcome to ${NotificationService.appName}`;
    }
};
// 7. Execution
console.log(getWelcomeMessage("Bhavana"));
console.log(getUserInfo("Bhavana", 22));
console.log(getUserInfo("Bhavana"));
console.log(getSubscriptionStatus("Bhavana", true));
console.log(isEligibleForPremium(22));
console.log(getAlertMessage("New update available"));
console.log(NotificationService.sendNotification("Bhavana"));
