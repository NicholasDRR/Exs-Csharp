using System;
using Book;
using SuperBook;

PhotoBook photoBook = new();

System.Console.WriteLine(photoBook.GetNumPage());

PhotoBook photoBook2 = new(24);

System.Console.WriteLine(photoBook2.GetNumPage());

SuperPhotoBook superPhotoBook = new();

System.Console.WriteLine(superPhotoBook.numPages);


Console.ReadKey();
