Lustd
=====

![Lustd Logo](Assets/Lustd-Branding.png)

Lusted is a set of WPF styles that aspire to be, as the name purports, less ugly than the default style present in a raw WPF project.

You will find no claims of excellence, completeness, nor beauty here; for projects larger than a knick-knack, something more complete and established would likely deliver more satisfaction. 

That aside, Lustd was created to simplify consistency and appearance among my own tools and projects, and intends not to over promise nor underdliver. 

Release
-------

[Available on Nuget!](https://www.nuget.org/packages/Lustd/1.0.0)

``` PowerShell
Install-Package Lustd -Version 1.0.0
```

Internals
---------

The contents of Lustd at split in to 3 categories; Themes, Schemes, and Highlights. Themes define the structure of components, via control templates and styles; Schemes offer a colour scheme; Highlights provide a visually dominant colour for use as required.

Installation
------------

1. Add nuget package to project.
2. Add a chosed Theme, Scheme, and Highlight to your `app.xaml` file.
3. Set the `Window` style if desired. 

Example
-------

### `app.xaml`

``` xml
<Application x:Class="Example.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             StartupUri="MainWindow.xaml">
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="pack://application:,,,/Lustd;component/Schemes/DarkScheme.xaml" />
                <ResourceDictionary Source="pack://application:,,,/Lustd;component/Themes/DefaultTheme.xaml" />
                <ResourceDictionary Source="pack://application:,,,/Lustd;component/Highlights/TurboHighlight.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

### `MainWindow.xaml.cs`

``` cs
namespace Example.App
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Style = (Style)FindResource(typeof(Window));
            InitializeComponent();
        }
    }
}
```

> **Note:** The `Window` style must be set if desired; it will not be set automatically. 
