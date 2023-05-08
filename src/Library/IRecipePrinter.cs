using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    
    public interface IRecipePrinter
    {
        void PrintRecipe(Recipe recipe);
    }

}

//en vez de usar la clase AllInOnePrinter cree la clase FilePrinter, ConsolePrinter y la interfaz IRecipePrinter
//aplicando Polimorfismo