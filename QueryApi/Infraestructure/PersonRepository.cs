using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Reflection.PortableExecutable;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using QueryApi.Domain;
using System.Threading.Tasks;

namespace QueryApi.Repositories
{
    public class PersonRepository
    {
        List<Person> _persons;

        public PersonRepository()
        {
            var fileName = "dummy.data.queries.json";
            if(File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                _persons = JsonSerializer.Deserialize<IEnumerable<Person>>(json).ToList();
            }
        }

        // retornar todos los valores
        public IEnumerable<Person> GetAll()
        {
            var query = _persons.Select(person => person);
            return query;
        }

        // retornar campos especificos
        public IEnumerable<Object> GetFields()
        {
            var query =_persons.Select(person => new{
                NombreCompleto = $"{person.FirstName} {person.LastName}",
                AnioNacimiento= DateTime.Now.AddYears((person.Age * -1)).Year,
                Correo = person.Email
            });
            return query;
        }

        // retornar elementos que sean iguales
        public IEnumerable<Person> GetById()
        {
            var generador = new Random(DateTime.Now.Millisecond);
            var id = generador.Next(1000);

            var query= _persons.Where(p => p.Id ==id);
            return query;
        }

        public IEnumerable <Person> GetByGender()
        {
            var gender ='F';
            var query= _persons.Where(person => person.Gender == gender);
            return query; 

        }
        
        // Retornar elementos que sean diferentes
        //public IEnumerable<string> GetJobs()
        //{
       //     var query = _persons.Select(person => person.Job).Distinct();
       //     return query;
       // }

        public IEnumerable<string> GetDistinctJobs()
        {
            var job = "Structural Engineer";
            var query = _persons.Where(p => p.Job != job).Select(p => p.Job).Distinct();
            return query;
        }
        
        // retornar valores que contengan
        public IEnumerable<Person> GetStartsWith()
        {
            var word = "Sales";
            var query = _persons.Where(p => p.Job.StartsWith(word));
            return query;
        }


         public IEnumerable<Person> GetEndstWith()
        {
            var word = "III";
            var query = _persons.Where(p => p.Job.EndsWith(word));
            return query;
        }

         public IEnumerable<Person> GetContains()
        {
            var word = "Designer";
            var query = _persons.Where(p => p.Job.Contains(word));
            return query;
        }

        public IEnumerable<Person> GetPeople()
        {
            var ages = new List <int>{25,35,45};
            var query = _persons.Where(p => ages.Contains(p.Age));
            return query;
        }
        // retornar valores entre un rango
        
        public IEnumerable<Person> GetRange()
        {
            var minAge=20;
            var maxAge=29;

            var query= _persons.Where(p => p.Age >= minAge && p.Age <= maxAge);
            return query;
        }
        // retornar elementos ordenados
        
        public IEnumerable<Person> GetOrdered()
        {
            var gender = 'F';
            var query = _persons.Where(person => person.Gender == gender).OrderBy(person => person.Age);
            return query;
        }

         public IEnumerable<Person> GetOrderedDesc()
        {
            var gender = 'F';
            var query = _persons.Where(person => person.Gender == gender).OrderByDescending(person => person.Age);
            return query;
        }


        // Ordenar por más de una columna
        public IEnumerable<Person> GetOrderedby2()
        {
            var query = _persons.OrderBy(person => person.Age).ThenBy(person => person.Job);
            return query;
        }

        public IEnumerable<Person> GetOrderMultiColumns()
        {
            var minAge =20;
            var maxAge=20;
            var job = "Analyst Programmer";

            var query = _persons.Where(p => p.Age >= minAge && p.Age <= maxAge && p.Job == job ).OrderBy(p => p.Age).ThenBy(p => p.Id);
            return query;
        }

        // retorno cantidad de elementos
        
        public int GetCount()
        {
            var job = "Software Consultant";
            var query= _persons.Where(p => p.Job == job).Count();
            return query;
        }

        // Evalua si un elemento existe
        public bool GetExist()
        {
            var firstName = "Locke";
            var query = _persons.Exists(person => person.FirstName == firstName);
            return query;
        }

        public bool GetAny()
        {
            var lastName = "Benettolo";
            var query = _persons.Any( person => person.LastName == lastName);
            return query;
        }

        // retornar solo un elemento
        
        public Person GetByid2()
        {
            //var generador = new Random(DateTime.Now.Millisecond);
           // var id = generador.Next(1000);
           //var id = 796;
           var job = "Legal Assistant";
            
            //var query = _persons.Single(p => p.Job == job);
            var query = _persons.First(p => p.Job == job);
            return query;
        }


        // retornar solamente unos elementos
        
        public IEnumerable<Person> GetTake()
        {
           var job = "Professor";
           var take = 3;
           var query = _persons.Where( p => p.Job == job).Take(take);
           return query; 
        }

        // retornar elementos saltando posición
        
    }
}