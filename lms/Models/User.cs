﻿namespace lms.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password {  get; set; }
        //role şimdilik string yaptım, auth eklendiğinde değişecek muhtemelen
        public string Role {  get; set; }
    }
}