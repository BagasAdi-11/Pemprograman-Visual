﻿namespace gymkuuu.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime TanggalLahir { get; set; }
    }
}
