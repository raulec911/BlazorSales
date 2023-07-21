﻿using BlazorSales.Server.Data;
using BlazorSales.Shared.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorSales.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly DataContext _context;
        public CountriesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _context.Countries.ToListAsync();
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetAsync(int Id)
        {
            var result = await _context.Countries.FirstOrDefaultAsync(c => c.Id == Id);
            if(result == null)
            { 
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(Country country)
        {
            _context.Countries.Add(country);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync(Country country)
        {
            _context.Countries.Update(country);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int Id)
        {
            var result = await _context.Countries.FirstOrDefaultAsync(c => c.Id == Id);
            if (result == null)
            {
                return NotFound();
            }

            _context.Countries.Remove(result);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}