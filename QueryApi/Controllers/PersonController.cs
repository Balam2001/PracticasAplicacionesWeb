using Microsoft.AspNetCore.Mvc;
using QueryApi.Domain.Entities;
using QueryApi.Domain.Dtos;
using System.Collections.Generic;
using System.Linq;
using QueryApi.Infraestructure.Repositories;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetFields")]
        public IActionResult GetFields()
        {
            var repository = new PersonRepository();
            var persons = repository.GetFields();
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetByGender")]
        public IActionResult GetByGender(char Gender)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByGender(Gender);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetRange")]
        public IActionResult GetRange(int minAge, int maxAge)
        {
            var repository = new PersonRepository();
            var persons = repository.GetRange(minAge,maxAge);
            return Ok(persons);
        }  

        [HttpGet]
        [Route("GetJobs")]
        public IActionResult GetJobs()
        {
            var repository = new PersonRepository();
            var persons = repository.GetJobs();
            return Ok(persons);
        }    

        [HttpGet]
        [Route("GetContains")]
        public IActionResult GetContains(string word)
        {
            var repository = new PersonRepository();
            var persons = repository.GetContains(word);
            return Ok(persons);
        } 

        /*[HttpGet]
        [Route("GetPeople")]
        public IActionResult GetPeople(int Age1,int Age2,int Age3)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPeople(Age1,Age2,Age3);
            return Ok(persons);
        }*/
        
        [HttpGet]
        [Route("GetOrdered")]
        public IActionResult GetOrdered(int age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetOrdered(age);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetOrderedDesc")]
        public IActionResult GetOrderedDesc(char gender, int minAge,int maxAge)
        {
            var repository = new PersonRepository();
            var persons = repository.GetOrderedDesc(gender,minAge,maxAge);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetCount")]
        public IActionResult GetCount(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.GetCount(gender);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetExist")]
        public IActionResult GetExist(string LastName)
        {
            var repository = new PersonRepository();
            var persons = repository.GetExist(LastName);
            return Ok(persons);
        }

        [HttpGet]
        [Route("JobAge")]
        public IActionResult JobAge(string Job, int age)
        {
            var repository = new PersonRepository();
            var persons = repository.JobAge(Job,age);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetTake")]
        public IActionResult GetTake(string job, int Take)
        {
            var repository = new PersonRepository();
            var persons = repository.GetTake(job,Take);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetSkip")]
        public IActionResult GetSkip(int skip,string job)
        {
            var repository = new PersonRepository();
            var persons = repository.GetSkip(skip,job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetSkipTake")]
        public IActionResult GetSkipTake(int skip,int take, string job)
        {
            var repository = new PersonRepository();
            var persons = repository.GetSkipTake(skip,take,job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("Find")]
        public IActionResult GetByFilter([FromBody]PersonRequest person)
        {
            var repository = new PersonRepository();
            var persona = CreateObjectFromDto(person);
            var personas = repository.GetByFilter(persona);
            var respuesta = CreateDtoFromObject(personas);

            return Ok(respuesta);
        }

        private IEnumerable<PersonResponse> CreateDtoFromObject(IEnumerable<Person> personas)
        {
            var dtos = personas.Select(x => new PersonResponse(
                Name : $"{x.FirstName} {x.LastName}",
                Email : x.Email,
                ZipCode : x?.Address.City
            ));
            return dtos;
        }

        public Person CreateObjectFromDto(PersonRequest dto)
        {
            var persona = new Person{
                Id = 0,
                FirstName = string.Empty,
                LastName = string.Empty,
                Email = string.Empty,
                Gender = dto.Gender.Value,
                Job = string.Empty,
                Age = dto.Age,
                Address = new Address{
                    Street = string.Empty,
                    Number = string.Empty,
                    ZipCode = string.Empty,
                    City = dto.City

            }
            };
            return persona;
        }
    }
}