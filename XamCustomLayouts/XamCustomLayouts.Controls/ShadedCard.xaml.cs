using Xamarin.Forms;

namespace XamCustomLayouts.Controls
{
    public partial class ShadedCard : Frame
    {
        public ShadedCard()
        {
            InitializeComponent();
        }

        #region Bindable Properties

        #region Icon

        public static BindableProperty IconProperty = BindableProperty.Create(nameof(Icon), typeof(ImageSource), typeof(ShadedCard), propertyChanged: IconTitleGridVisible);

        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        #endregion

        #region Title

        public static BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(ShadedCard), propertyChanged: IconTitleGridVisible);

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        #endregion

        #region TitleStyle

        public static BindableProperty TitleStyleProperty = BindableProperty.Create(nameof(TitleStyle), typeof(Style), typeof(ShadedCard), defaultValue: (Style)Application.Current.Resources["SectionTitleText"]);

        public Style TitleStyle
        {
            get { return (Style)GetValue(TitleStyleProperty); }
            set { SetValue(TitleStyleProperty, value); }
        }

        #endregion

        #region Main Content

        public static BindableProperty CardContentProperty = BindableProperty.Create(nameof(CardContent), typeof(View), typeof(ShadedCard), propertyChanged: IconTitleGridVisible);

        public View CardContent
        {
            get { return (View)GetValue(CardContentProperty); }
            set { SetValue(CardContentProperty, value); }
        }

        #endregion

        #region Action Items View

        public static BindableProperty ActionViewProperty = BindableProperty.Create(nameof(ActionView), typeof(View), typeof(ShadedCard));

        public View ActionView
        {
            get { return (View)GetValue(ActionViewProperty); }
            set { SetValue(ActionViewProperty, value); }
        }

        #endregion

        #endregion


        #region Property Changed Methods

        private static void IconTitleGridVisible(BindableObject bindable, object oldValue, object newValue)
        {
            var view = (ShadedCard)bindable;

            view.IconTitleGrid.IsVisible = (!string.IsNullOrEmpty(view.Title) || view.Icon != null);
        }

        #endregion
    }
}
