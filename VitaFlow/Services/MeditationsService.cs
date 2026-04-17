using projeto_carlos.Models;

namespace projeto_carlos.Services
{
    public interface IMeditationsService
    {
        List<Meditation> GetMeditations();
        List<Meditation> GetFeaturedMeditations();
    }

    public class MeditationsService : IMeditationsService
    {
        private readonly List<Meditation> _meditations = new()
        {
            new Meditation
            {
                Title = "Morning Clarity",
                Description = "Start your day with intention and clear focus. This guided session helps you set positive anchors for the hours ahead.",
                DurationMinutes = 15,
                Category = "Focus",
                SubCategory = "Morning Start",
                IsFeatured = true,
                ImageUrl = "https://lh3.googleusercontent.com/aida-public/AB6AXuD19huqLTvePKGA-C-IJS8ie94c9uju3wQP4tHCJCDhXbjj6F0zWJTYW7WyL_uZHkFuG9QHhzTdj4gilf9F33Q8TQmFvYQrNPO1KvbXiWLN8uIZRZGpi0mHKvFLanzsdNJkt_WPiQp4VM_6DHEQEHZ0KJSic4_0psC_Qk72cVVKU9dieRiEFOJZxCnE8OmpvU7Q5JNYjQ5eMqQt34r-kmKo8HfsLllDJSAb_muDKIaoE7C00bBxqHa0YMtZNKS0DCNy0v1yP7DuR8dY"
            },
            new Meditation
            {
                Title = "Deep Restorative Sleep",
                Description = "Drift off naturally with progressive relaxation and soft ambient tones.",
                DurationMinutes = 20,
                Category = "Sleep",
                SubCategory = "Deep Sleep",
                ImageUrl = "https://lh3.googleusercontent.com/aida-public/AB6AXuAKd-qLInnZC_dZTrln9QPvG2GiafeYdm9qjnl7nQ1eU3ihV5L_i_TN74Zddjm7ZvrRT86M9hpIpejaww6vfCttUjF-SMLd8H5Eeh1OH0ltyuJjX2vwI6R_gP4MLUVbn7r-ofZs3pVSE-kxar56Ipmj82tFJAebal7Ft1QSuh4F2aVPSlJfLs5RUcl9sIRWADhqN27wQ8krrVY3nEPa0zhqhtjVKVI3bYwYfjB2oCKImxUJHAoux2qMcIzkC0v5QgCrGDOd2gRS2a7L"
            },
            new Meditation
            {
                Title = "Anxiety Release",
                Description = "Quick breathing exercises to ground yourself in moments of high stress.",
                DurationMinutes = 10,
                Category = "Relief",
                SubCategory = "Anxiety Relief",
                ImageUrl = "https://lh3.googleusercontent.com/aida-public/AB6AXuANLteHR_kB8djEK1FwvPeh_HZM3bRsIwp-tWgqAY-Jg3YGXNIlSdfOagCbWNj1adB_ngmwgbIp46WQnHAC5oekmpRWvLSk3zEo3Tbl1YKTKPOBpioED2QKopt5iKcGzaMsumFwC_gcSeFevdZZvQ7_NVca4RpkEe4diY9M5W0vlBaViBUzsIcQQGVbZnuSebkVtmAcfDBGne8jzxbPG-7cFBwZIv8S7QVL4ezYzNljYVC5dVr1xahYbgvBgM_my0zOmmoZItLitZSm"
            },
            new Meditation
            {
                Title = "Sustained Focus",
                Description = "Binaural beats and soft guidance to enter a state of deep work flow.",
                DurationMinutes = 25,
                Category = "Focus",
                SubCategory = "Focus Flow",
                ImageUrl = "https://lh3.googleusercontent.com/aida-public/AB6AXuDfX9Kzlq1RKmm9jlG4OXP83JWKM2pqTaUhvNUPtorX9t-0D5pYXR2Jm-4oWAU7ZD8DN28MsvT88ebqvzfO5cPQsPHHKbhNt-Rsmo0pM6XRd_2ItWTkWD207Vzrd-7wsR0-Bk_4Cv0Yb4FcA3HuZ7oAfa3IikHRr9FeKYUHxFOV6YZmpeZv61_LBvgsjtLFYE8OfH2rgGgxFAJDqCbXZV9v0IdHCBkvXhM1SbXMUKrWarevIm14uAZiQRF4M_IbJ4O7g5zuXp9nZTIg"
            }
        };

        public List<Meditation> GetMeditations() => _meditations;

        public List<Meditation> GetFeaturedMeditations() => _meditations.Where(m => m.IsFeatured).ToList();
    }
}
