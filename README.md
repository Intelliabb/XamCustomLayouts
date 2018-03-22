# Card View Using Custom Layouts In Xamarin.Forms
This sample shows how to create a custom layout (container) that can be reused in the app and can take any `View` as child.

Blog post: <link>

## Card View

### iOS

![iOS](/Screenshots/ios.png)

### Android

![Android](/Screenshots/android.png)

## Parts
1. Icon
2. Title
3. Content View (`ContentPresenter`)
4. Action View (`ContentPresenter`)

All parts are optional. You can mix and match to your needs.

## Usage

### In XAML
Depending on where you place your custom layout/control, bring in the namespace, if needed.

`xmlns:controls="clr-namespace:XamCustomLayouts.Controls;assembly=XamCustomLayouts.Controls" `

then,
```
<controls:ShadedCard Icon="profile.png" Title="Card With Shadow" CornerRadius="0" HasShadow="true" TitleStyle="{StaticResource SectionTitleText}">
  <controls:ShadedCard.CardContent>
      <Label Text="Welcome to intelliAbb!" VerticalOptions="Center" HorizontalOptions="Center" />
  </controls:ShadedCard.CardContent>
  <controls:ShadedCard.ActionView>
      <Button Text="Update"/>
  </controls:ShadedCard.ActionView>
</controls:ShadedCard>

```

### In C#
```
var card = new ShadedCard {
  Icon = "icon.png",
  Title = "My Card",
  ContentView = new StackLayout {
    . . .
  },
  ActionView = new StackLayout {
    . . .
  },
};

// assuming you have a child-bearing container as parent,
Parent.Children.Add(card);
```

Enjoy!
