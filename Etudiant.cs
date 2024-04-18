using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Etudiant
    {
        public string _firstname { get; set; }
        public string _lastname{ get; set; }
        public DateOnly _birthdate{ get; set; }
        public int _id { get; set; }

        public List<double> _notes {  get; set; }

        public string _commentaires {  get; set; }
        public List<int> _cours { get; set; }


        public Etudiant(string firstname, string lastname) {
            _firstname = firstname;
            _lastname = lastname;
            _notes = new List<double>();
            _cours = new List<int>();
        }
        public void SetNote(double note) {
             _notes.Add(note);
        }
        public void SetCommentaire(string commentaire) {
               _commentaires = commentaire;
        }

        public double CalculeMoyenne() {
            double result = 0;
            return result;
        }
        public void SetCours(int cours)
        {
            _cours.Add(cours);
        }
        public void DisplayEtudiant()
        {

        }
        public void ListEtudiants()
        {

        }

        public void CreateEtudiants()
        {

        }
    }
}
