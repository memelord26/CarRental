using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRental.Server.Data;
using CarRental.Shared.Domain;
using CarRental.Server.IRepository;

namespace CarRental.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public MakesController(ApplicationDbContext context)
        public BookingsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Booking
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Make>>> GetBooking()
        public async Task<IActionResult> GetBooking()
        {
            //Refactored
            //return await _context.Booking.ToListAsync();
            var booking = await _unitOfWork.Bookings.GetAll();
            return Ok(booking);
        }

        // GET: api/Booking/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Booking>> GetBooking(int id)
        public async Task<ActionResult> GetBooking(int id)
        {
            //Refactored
            //var bookings = await _context.Booking.FindAsync(id);
            var bookings = await _unitOfWork.Bookings.Get(q => q.Id == id);

            if (bookings == null)
            {
                return NotFound();
            }

            return Ok(bookings);
        }

        // PUT: api/Booking/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, Booking bookings)
        {
            if (id != bookings.Id)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(bookings).State = EntityState.Modified;
            _unitOfWork.Bookings.Update(bookings);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!bookingsExists(id))
                if (!await BookingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Booking
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(Booking bookings)
        {
            //Refactored
            //_context.Booking.Add(bookings);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Bookings.Insert(bookings);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBooking", new { id = bookings.Id }, bookings);
        }

        // DELETE: api/Booking/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            //Refactored
            //var bookings = await _context.Booking.FindAsync(id);
            var bookings = await _unitOfWork.Bookings.Get(q => q.Id == id);
            if (bookings == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Booking.Remove(bookings);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Bookings.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool BookingExists(int id)
        private async Task<bool> BookingExists(int id)
        {
            //Refactored
            //return _context.Booking.Any(e => e.Id == id);
            var bookings = await _unitOfWork.Bookings.Get(q => q.Id == id);
            return bookings != null;
        }
    }
}
