# Card View Using Custom Layouts In Xamarin.Forms
This sample shows how to create a custom layout (container) that can be reused in the app and can take any `View` as child.

Blog post: https://intelliabb.com/2018/03/21/card-view-for-xamarin-forms-using-custom-layouts/

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

## MVVM Data Binding
If you are using MVVM in your Xamarin.Forms app (as you should :)), you will find that binding to a control inside a view that is child of this card view, the implicit bindings will not work as the child control does not know about the grandparent control (page) and it's binding context. So, you will have to explicitly bind to the page's binding context by simply doing the following,

1. Name your page. i.e. `<... x:Name="MyPage"/>`
2. Bind explicitly. i.e. `<Label Text="{Binding BindingContext.PropertyName, Source={x:Reference MyPage}}"/>`

That is it. You just told your grand child control/view to bind to `MyPage`'s `BindingContext`, which is your `ViewModel`.

Enjoy!
