Lustd
=====

![Lustd Logo](Assets/Lustd-Branding.png)

Lusted is a set of WPF styles that aspire to be, as the name purports, less ugly than the default style present in a raw WPF project.

You will find no claims of excellence, completeness, nor beauty here; for projects larger than a knick-knack, something more complete and established would likely deliver more satisfaction. 

That aside, Lustd was created to simplify consistency and appearance among my own tools and projects, and intends not to over promise nor underdliver. 

Release
-------

[Available on Nuget!](https://www.nuget.org/packages/Lustd/)

``` PowerShell
Install-Package Lustd
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
                <ResourceDictionary Source="pack://application:,,,/Lustd;component/Themes/DefaultTheme.xaml" />
                <ResourceDictionary Source="pack://application:,,,/Lustd;component/Schemes/DarkScheme.xaml" />
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

> **Note:** The `Window` style must be set if desired; it will not be set automatically. This can be avoided by instead inheriting from `LustdWindow`.

Resources
---------

### Controls

#### LustdWindow

##### Usage:

``` xml
<controls:LustdWindow x:Class="Lustd.Demo.MainWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    xmlns:controls="clr-namespace:Lustd.Controls;assembly=Lustd"
    mc:Ignorable="d"
    Title="MainWindow" Height="450" Width="800">

    <!-- Window Content -->

</controls:LustdWindow>
```

#### LustdWindowEnhanced

##### Usage:

``` xml
<controls:LustdWindowEnhanced x:Class="Lustd.Demo.MainWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    xmlns:controls="clr-namespace:Lustd.Controls;assembly=Lustd"
    mc:Ignorable="d"
    Title="MainWindow" Height="450" Width="800">


    <controls:LustdWindowEnhanced.TitleContent>
        <!-- Alt Window Title here. -->
    </controls:LustdWindowEnhanced.TitleContent>

    <controls:LustdWindowEnhanced.ActionContent>
        <!-- Alt Titlebar Action Content here. -->
    </controls:LustdWindowEnhanced.ActionContent>

    <controls:LustdWindowEnhanced.CommandContent>
        <!-- Alt Titlebar Action Content here, with consistent Button and ToggleButton styles. -->
        <StackPanel Margin="10,0" Orientation="Horizontal">
            <Button x:Name="SettingsButton" ToolTip="Settings">
                <TextBlock FontFamily="Segoe MDL2 Assets" Text="&#xE713;" />
            </Button>
        </StackPanel>
    </controls:LustdWindowEnhanced.CommandContent>

    <!-- Window Content -->

</controls:LustdWindowEnhanced>
```

### Themes

#### DefaultTheme

### Schemes

#### DarkScheme

#### LightScheme

### Highlights

#### CaribbeanGreenHighlight

- ![#03965A](https://placehold.it/15/03965A/000000?text=+) `#03965A`
- ![#03CD7B](https://placehold.it/15/03CD7B/000000?text=+) `#03CD7B`
- ![#47DA9F](https://placehold.it/15/47DA9F/000000?text=+) `#47DA9F`

#### DefaultHighlight

- ![#3268E8](https://placehold.it/15/3268E8/000000?text=+) `#3268E8`
- ![#3772FF](https://placehold.it/15/3772FF/000000?text=+) `#3772FF`
- ![#91B2FF](https://placehold.it/15/91B2FF/000000?text=+) `#91B2FF`

#### FuchsiaBlueHighlight

- ![#624690](https://placehold.it/15/624690/000000?text=+) `#624690`
- ![#865FC5](https://placehold.it/15/865FC5/000000?text=+) `#865FC5`
- ![#A78AD4](https://placehold.it/15/A78AD4/000000?text=+) `#A78AD4`

#### TurboHighlight

- ![#CCEE00](https://placehold.it/15/CCEE00/000000?text=+) `#CCEE00`
- ![#DDDD00](https://placehold.it/15/DDDD00/000000?text=+) `#DDDD00`
- ![#EECC00](https://placehold.it/15/EECC00/000000?text=+) `#EECC00`

#### MandyHighlight

- ![#BE4E4C](https://placehold.it/15/BE4E4C/000000?text=+) `#BE4E4C`
- ![#E85F5C](https://placehold.it/15/E85F5C/000000?text=+) `#E85F5C`
- ![#EC7C79](https://placehold.it/15/EC7C79/000000?text=+) `#EC7C79`
