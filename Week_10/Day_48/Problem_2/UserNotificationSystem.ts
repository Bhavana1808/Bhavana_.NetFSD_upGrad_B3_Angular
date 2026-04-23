// 1. Required Parameter
function getWelcomeMessage(name: string): string {
  return `Welcome, ${name}!`;
}

// 2. Optional Parameter
function getUserInfo(name: string, age?: number): string {
  if (age) {
    return `${name} is ${age} years old`;
  }
  return `${name} age not provided`;
}

// 3. Default Parameter
function getSubscriptionStatus(name: string, isSubscribed: boolean = false): string {
  return isSubscribed
    ? `${name} is subscribed`
    : `${name} is not subscribed`;
}

// 4. Boolean Return
function isEligibleForPremium(age: number): boolean {
  return age > 18;
}

// 5. Arrow Function
const getAlertMessage = (msg: string): string => {
  return `Alert: ${msg}`;
};

// 6. Lexical this
const NotificationService = {
  appName: "MyApp",

  sendNotification: (user: string): string => {
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