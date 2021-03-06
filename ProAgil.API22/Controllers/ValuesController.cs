﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProAgil.API22.Data;
using ProAgil.API22.model;



namespace ProAgil.API22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public DataContext _context { get; }

        public ValuesController(DataContext context){
            
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
         {

             try{

                 var results = _context.Eventos.ToList(); 
                 return Ok(results);
             }
             catch (System.Exception){
                 return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
                 
             }
           
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id){
            return _context.Eventos.FirstOrDefault(x => x.EventoId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
