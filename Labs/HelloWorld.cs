<Page
    x:Class="HelloWorld.MainPage"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:HelloWorld"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    mc:Ignorable="d"
    Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
    <Grid>
        <TextBlock HorizontalAlignment="Left" Margin="150,180,0,0" Text="Please enter your name" TextWrapping="Wrap" 
               VerticalAlignment="Top" FontSize="36"/>
        <TextBox x:Name="UserName" HorizontalAlignment="Left" Margin="150,328,0,0" Text="" TextWrapping="Wrap" VerticalAlignment="Top" Height="128" Width="482" FontSize="36"/>
        <Button x:Name="OK" Content="OK" Margin="750,328,0,0" VerticalAlignment="Top" Height="128" Width="388" FontSize="36" Click="OK"/>


    </Grid>

</Page>