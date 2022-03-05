using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace Examen_Kadir_Flores.Pages.Instituciones
{
    public class GridModel : PageModel
    {
        private readonly IInstitucionService institucion;

        public GridModel(IInstitucionService institucion)
        {
            this.institucion = institucion; 
        }

        public IEnumerable<Institucion> GridLista { get; set; } = new List<Institucion>();

        public string Mensaje { get; set; } = "";

        public async Task<IActionResult> OnGet()
        {
            try
            {
                GridLista = await institucion.GET();

                if (TempData.ContainsKey("Msg"))
                {
                    Mensaje = TempData["Msg"] as string;
                }
                TempData.Clear();

                return Page();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }

        public async Task<IActionResult> OnGetEliminar(int id)
        {
            try
            {
                var result = await institucion.DELETE(new() 
                {Id_Intitucion = id });

                if(result.CodError!=0)
                {
                    throw new Exception(result.MsgError);
                }

                TempData["MSg"] = "El registro fue eliminado exitosamente";

                return Redirect("Grid");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
    }
}
