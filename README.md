# MultiColumnsListView
Xamarin.Forms subclassed ListView for a multi-columns look

## What is it about

A Xamarin.Forms subclassed ListView along with some other subclassed controls to create a multi-column recyclable ListView.<br>
No custom renderers, just pure Forms, tested on iOS and Android.

<p align="center">
  <img height="400" src="https://github.com/taublast/MultiColumnsListView/blob/master/Screenshot_1555781169.jpg">
  <img height="400" src="https://github.com/taublast/MultiColumnsListView/blob/master/Screenshot_1555781171.jpg">
  <img height="400" src="https://github.com/taublast/MultiColumnsListView/blob/master/Screenshot_1555781163.jpg">
</p>

<p align="center">
  Try click on "Change Cols" it will switch 1-2-3 columns, the "Add" button works too..
</p>

### How

The main idea was to have several cell templates and switch them between a table row and an empty template for cells that have already been used in the row. 

#### Cell Templates

System templates will be used to create the multi-columns look.<br>
Template 1: A table in wich we are going to place our columns for every row<br>
Template 2: An empty cell template for those items residing above, in the table from template #1.<br>
Template 3: An optional cell template for a case we have only 1 column selected. It is not really needed, we can just use the template #1 with 1 column, but it’s an option for purists.<br>
You could override the resulting template with your own, after our selector has produced one.<br>

And you will of course have your own cell template that will be used by the table from template #1 to fill its columns and to create your unique design.<br>

The resulting look must be the following (2 columns):

[ Template1: [user template cell 1] [user template cell 2] ]

[ Template 2 ]

[ Template1: [user template cell 3] [user template cell 4] ]

[ Template 2 ]

…

## The ListView

You will notice that in the re-subclassed MonkeysListView we could set the caching strategy at will upon platform.
An important note is that with our custom data selector you cannot use RecycleElementAndDataTemplate. 
Another note is that you cannot use RecycleElement when you use uneven rows otherwise it will create a junky effect, but with even rows of fixed equal height it’s no problem. In this example we had uneven rows so we used RetainElement. 


## A Quick Note

The project was created using a standart Xamarin.Forms Shell template, then adding custom controls inside. 
Microsoft.CSharp nuget was added for dynamic extensions but you can adapt to your hardcoded classes and remove it.


## Known bugs

Xamarin Image on Android is not loading our images at intended with an "ImageLoaderSourceHandler: Could not retrieve image or image data was invalid", so we are fixing this using a ported Glide image loading handler (https://github.com/jonathanpeppers/glidex). My bet is any custom loader would solve this issue, as long as xamarin out-of-the-box is not working in this case.


## Stay Tuned

For even more Xamarin content: https://twitter.com/nickkovalsky


## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details


