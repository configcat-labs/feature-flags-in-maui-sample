# ConfigCat Feature Flags with .NET MAUI

The app is a simple page that enables users to vote on a photo by assigning grades from 1 to 10. Using [ConfigCat's](https://configcat.com/) feature flag services, the application cointains a feature flag that is meant to enable and disable the voting feature of the application. When disabled, users see an error message.

The sample app in this repository is a single page application that displays a picture of [ConfigCat's](https://configcat.com/) cat logo. In order to demonstrate the usage of feature flags, the app is connected to the ConfigCat feature flag service via an SDK and SDK key. When the flag is turned on, the cat is displayed. Once the flag is turned off, the cat dissapears and a new message is displayed to the user.

The two cases can be seen in this screenshot:

## Prerequisites

- Visual Studio with the .NET Multi-platform App UI development workload. More information **[here](https://dotnet.microsoft.com/en-us/learn/maui/first-app-tutorial/install)**
- C# knowledge
- Android or iOS emulator (optional)

## Setup and Run

- Clone repository
- Install ConfigCat SDK by using `dotnet add package ConfigCat.Client --version 6.5.3` in the project folder (ex. mauiExample/mauiExample)
- Open project in Visual Studio
- Run on Desktop
- Run on Android (optional). More information **[https://dotnet.microsoft.com/en-us/learn/maui/first-app-tutorial/device-setup]()**

## Learn more

Read more about .NET MAUI **[here](https://learn.microsoft.com/en-us/dotnet/maui/what-is-maui)**
Read more about **[setting up .NET MAUI](https://dotnet.microsoft.com/en-us/learn/maui/first-app-tutorial/intro)**

[**ConfigCat**](https://configcat.com) also supports many other frameworks and languages. Check out the full list of supported SDKs [here](https://configcat.com/docs/sdk-reference/overview/)

You can also explore other code samples for various languages, frameworks, and topics here in the [ConfigCat labs](https://github.com/configcat-labs) on GitHub.

Keep up with ConfigCat on [Twitter](https://twitter.com/configcat), [Facebook](https://www.facebook.com/configcat), [LinkedIn](https://www.linkedin.com/company/configcat/), and [GitHub](https://github.com/configcat).

## Author

[Roxana Halati](https://github.com/roxanahalati)

## Contributions

Contributions are welcome!
