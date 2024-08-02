﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {


    public IEnumerable<Evento> _evento = new Evento[]
     {

                new Evento(){
                EventoId = 1,
                Local = "São Paulo",
                Tema = "Angular 11 .NET 5",
                QtdPessoas = 250,
                Lote = "1º Lote",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
            },
            new Evento(){
                EventoId = 2,
                Local = "Belo Horizonte",
                Tema = "Angular sua novidades",
                QtdPessoas = 350,
                Lote = "2º Lote",
                DataEvento = DateTime.Now.AddDays(3).ToString(),
                ImagemURL = "foto.png"
            }

     };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }


        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById( int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }


        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
