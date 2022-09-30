using Microsoft.AspNetCore.Mvc;

namespace MVCTest.Models
{
    public class Cliente
    {
        private string? name;
        private int edad;

        public string? Name { get => name; set => name = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
