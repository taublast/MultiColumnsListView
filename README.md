# MultiColumnsListView
Xamarin.Forms subclassed ListView for a multi-columns look

## What is it about

A Xamarin.Forms subclassed ListView along with some other subclassed controls to create a multi-column recyclable ListView.<br>
No custom renderers, just pure Forms.

<p align="center">
  <img height="400" src="https://github.com/taublast/MultiColumnsListView/blob/master/Screenshot_1555781169.jpg">
  <img height="400" src="https://github.com/taublast/MultiColumnsListView/blob/master/Screenshot_1555781171.jpg">
  <img height="400" src="https://github.com/taublast/MultiColumnsListView/blob/master/Screenshot_1555781162.jpg">
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

And you will of course we have your own cell template that will be used by the table from template #1 to fill its columns and to create your unique design.<br>

The resulting look must be the following (2 columns):

[ Template1: [user template cell 1] [user template cell 2] ]

[ Template 2 ]

[ Template1: [user template cell 3] [user template cell 4] ]

[ Template 2 ]

…

## ToDo: 

Explain the code, maybe create a blog post. 
Until then please feel free to play with the source code, custom controls are in a shared project  so you can include them easily in your own soluctions.
The implementation is in the cross-platform project, please take a look i have left some comments inside.


## A Quick Note

The project was created using a standart Xamarin.Forms Shell template, then adding custom controls inside. 
Microsoft.CSharp nuget was added for dynamic extensions but you can adapt to your hardcoded classes and remove it.


## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
