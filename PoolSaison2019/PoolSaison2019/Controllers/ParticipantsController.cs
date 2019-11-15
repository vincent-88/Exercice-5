﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PoolSaison2019.Data;
using PoolSaison2019.Models;

namespace PoolSaison2019.Controllers
{
    public class ParticipantsController : Controller
    {
        private IRepository<Participant> _participantRepository;

        public ParticipantsController(IRepository<Participant> participantRepository)
        {
            _participantRepository = participantRepository;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _participantRepository.GetAll());
        }
    }
}
