# What's the weather in your city?

This app is a simple example of using ASP.NET Core with Angular 2.

The **.csproj file will not open in Visual Studio 2015** as it has been upgraded to use the new MSBuild .csproj format supported by Visual Studio 2017.

It was created using the [ASP.NET Core template pack](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.ASPNETCoreTemplatePack).

For more details/context, check out these [related blog posts](https://jonhilton.net/2016/12/01/fast-track-your-angular-2-and-net-core-web-app-development/).

Installation Instructions
--------------------------

To get this working you'll need to open up a command prompt (in the directory where you downloaded the source) and run the following command...

```
webpack --config webpack.config.vendor.js
```

and also this one...

```
webpack
```

With that you should see files in the wwwroot/dist folder.

For more details, see [Steve Sanderson's original blog post](http://blog.stevensanderson.com/2016/10/04/angular2-template-for-visual-studio/) introducing the template pack.

Secrets
--------

This example app relies on a number of "secrets"; sensitive information such as the client secret for authenticating via Google and the api Key for retrieving weather data from the OpenWeather Api.

Rather than store these values in plain text in the source code, we use the .NET Core User Secrets tool.

That does mean you'll need to plug in your own values to make the app work.

If you're using Visual Studio you can right-click the project and select "Manage User Secrets".

Then add the following.

```
{
  "googleClientId": "YOUR_GOOGLE_CLIENT_ID_GOES_HERE",
  "googleClientSecret": "YOUR_GOOGLE_CLIENT_SECRET_GOES_HERE",
  "openWeatherApiKey": "YOUR_OPENWEATHER_API_KEY"
}
```

If you're on the master branch (which doesn't, by default have any security), you can ignore the Google ones, but you'll need to add the OpenWeather API Key if you want that part of the app to work...

If you're not using Visual Studio, you can still manually edit this file. You'll typically find it here (the guid refers to the unique secrets id for this app)..

C:\Users\<YourUserName>\AppData\Roaming\Microsoft\UserSecrets\efebb820-2ce5-467e-8106-b1de32026492

Secure Version
--------------

If you want to see how to secure this app using OpenID Connect, check out the [secure branch](https://github.com/jonhilt/Angular-2-NET-Core-Weather-Checker/tree/secure).