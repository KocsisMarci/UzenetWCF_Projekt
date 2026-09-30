using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzenetWCF.Models;
namespace UzenetWCF.Interfaces
{
    public interface ICRUD  //Tekintve, hogy egy tábla van az interfész felesleges
    {
        List<Uzenet> Read();

        string Insert(Uzenet uzenet);

        string Update(Uzenet uzenet);

        string Delete(int id);
       
    }
}
