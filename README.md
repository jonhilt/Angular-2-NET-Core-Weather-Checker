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