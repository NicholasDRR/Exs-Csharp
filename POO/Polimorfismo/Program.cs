using _Figure;
using _Triangle;
using _Circle;
using System.Collections.Generic;

var figures = new List<Figure>
{
    new Circle(),
    new Triangle(),
};

foreach(var figure in figures)
{
    figure.Draw();
}

