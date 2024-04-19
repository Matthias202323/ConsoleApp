using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleApp
{
    public class Etudiant
    {
        public string _firstname { get; set; }
        public string _filename { get; set; }
        public string _lastname{ get; set; }
        public DateOnly _birthdate{ get; set; }
        public int _id { get; set; }

        public List<double> _notes {  get; set; }

        public string _commentaires {  get; set; }
        public List<int> _cours { get; set; }


        public Etudiant(string firstname, string lastname, string filename) {
            _filename = filename;
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
            JObject o1 = JObject.Parse(File.ReadAllText(@"c:\videogames.json"));

            // read JSON directly from a file
            using (StreamReader file = File.OpenText(@"c:\videogames.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o2 = (JObject)JToken.ReadFrom(reader);
            }
        }
        public void ListEtudiants()
        {
            JObject o1 = JObject.Parse(File.ReadAllText(@"c:\videogames.json"));

            // read JSON directly from a file
            using (StreamReader file = File.OpenText(@"c:\videogames.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o2 = (JObject)JToken.ReadFrom(reader);
            }
        }

        public void CreateEtudiants()
        {

        }
    }
}
