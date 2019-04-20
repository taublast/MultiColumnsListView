# MultiColumnsListView
Xamarin.Forms subclassed ListView for a multi-columns look

## What is it?

A Xamarin.Forms subclassed ListView along with some other classes to create a milti-columns recyclable ListView.

The project was created using a standart Xamarin.Forms Shell template, then adding custom controls inside. 
No custom renderers, just pure Forms.

Microsoft.CSharp nuget was added for dynamic extensions but you can adapt to your hardcoded classes and remove it.

<p align="center">
  <img height="400" src="http://appomobi.com/images/git/Screenshot_1555775167.jpg">
  <img height="400" src="http://appomobi.com/images/git/Screenshot_1555760450.jpg">
  <img height="400" src="http://appomobi.com/images/git/Screenshot_1555776853.jpg">
</p>

<p align="center">
  Try click on "Change Cols" it will switch 1-2-3 columns, "Add" button works too..
</p>

### How is it done

The main idea was to have several cell templates and switch them between a table row and an empty template for cells that have already been used in the row. 
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

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
