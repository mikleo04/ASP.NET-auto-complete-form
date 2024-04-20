using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace form_autocomplete_asp.Components;

public class HomeModel : PageModel
{
    
    [BindProperty]
    [Required(ErrorMessage = "Negara tidak boleh kosong")]
    public string Negara { set; get; } = "";
    
    [BindProperty]
    [Required(ErrorMessage = "Pelabuhan tidak boleh kosong")]
    public string Pelabuhan { set; get; } = "";
    
    [BindProperty]
    [Required(ErrorMessage = "Barang tidak boleh kosong")]
    public string Barang { set; get; } = "";
    
    [BindProperty]
    [Required(ErrorMessage = "Detail Barang tidak boleh kosong")]
    public string DetailBarang { set; get; } = "";
    
    [BindProperty]
    [Required(ErrorMessage = "Harga tidak boleh kosong")]
    public string Harga { set; get; } = "";
    
    [BindProperty]
    public string? TarifBeaMasuk { set; get; } = "";
    
    [BindProperty]
    [Required(ErrorMessage = "Result tidak boleh kosong")]
    public string Result { set; get; } = "";
}