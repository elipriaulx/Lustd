using System.Windows;
using System.Windows.Input;
using Lustd.Controls.Helpers;

namespace Lustd.Controls
{
    public abstract class LustdWindowEnhanced : Window
    {
        public static readonly DependencyProperty TitleContentProperty = DependencyProperty.Register(nameof(TitleContent), typeof(FrameworkElement), typeof(LustdWindowEnhanced), new UIPropertyMetadata(null));

        public static readonly DependencyProperty ActionContentProperty = DependencyProperty.Register(nameof(ActionContent), typeof(FrameworkElement), typeof(LustdWindowEnhanced), new UIPropertyMetadata(null));

        public static readonly DependencyProperty CommandContentProperty = DependencyProperty.Register(nameof(CommandContent), typeof(FrameworkElement), typeof(LustdWindowEnhanced), new UIPropertyMetadata(null));

        public static readonly DependencyProperty AllowTitleInteractionProperty = DependencyProperty.Register(nameof(AllowTitleInteraction), typeof(bool), typeof(LustdWindowEnhanced), new UIPropertyMetadata(false));
        
        static LustdWindowEnhanced()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LustdWindowEnhanced), new FrameworkPropertyMetadata(typeof(LustdWindowEnhanced)));
        }

        protected LustdWindowEnhanced()
        {
            SourceInitialized += (sender, e) => WindowHelpers.OnSourceInitialized(this);

            CommandBindings.Add(new CommandBinding(SystemCommands.CloseWindowCommand, (sender, e) => { SystemCommands.CloseWindow(this); }));
            CommandBindings.Add(new CommandBinding(SystemCommands.MaximizeWindowCommand, (sender, e) => { SystemCommands.MaximizeWindow(this); }, (sender, e) => { e.CanExecute = ResizeMode == ResizeMode.CanResize || ResizeMode == ResizeMode.CanResizeWithGrip; }));
            CommandBindings.Add(new CommandBinding(SystemCommands.MinimizeWindowCommand, (sender, e) => { SystemCommands.MinimizeWindow(this); }, (sender, e) => { e.CanExecute = ResizeMode != ResizeMode.NoResize; }));
            CommandBindings.Add(new CommandBinding(SystemCommands.RestoreWindowCommand, (sender, e) => { SystemCommands.RestoreWindow(this); }, (sender, e) => { e.CanExecute = ResizeMode == ResizeMode.CanResize || ResizeMode == ResizeMode.CanResizeWithGrip; }));

            Style = (Style)FindResource(typeof(LustdWindowEnhanced));
        }
        
        public FrameworkElement TitleContent
        {
            get => (FrameworkElement)GetValue(TitleContentProperty);
            set => SetValue(TitleContentProperty, value);
        }

        public FrameworkElement ActionContent
        {
            get => (FrameworkElement)GetValue(ActionContentProperty);
            set => SetValue(ActionContentProperty, value);
        }
        
        public FrameworkElement CommandContent
        {
            get => (FrameworkElement)GetValue(CommandContentProperty);
            set => SetValue(CommandContentProperty, value);
        }

        public bool AllowTitleInteraction
        {
            get => (bool)GetValue(AllowTitleInteractionProperty);
            set => SetValue(AllowTitleInteractionProperty, value);
        }
    }
}
