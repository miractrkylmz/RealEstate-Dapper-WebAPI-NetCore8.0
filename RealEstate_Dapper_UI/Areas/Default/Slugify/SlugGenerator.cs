using System.Text.RegularExpressions;

namespace RealEstate_Dapper_UI.Areas.Default.Slugify
{
    public static class SlugGenerator
    {
        public static string Slugify(this string title)
        {
            if (string.IsNullOrEmpty(title))
                return string.Empty;

            // Küçük harfe çevir
            title = title.ToLowerInvariant();

            // Türkçe karakterleri dönüştür
            title = title
                .Replace("ç", "c")
                .Replace("ğ", "g")
                .Replace("ı", "i")
                .Replace("ö", "o")
                .Replace("ş", "s")
                .Replace("ü", "u");

            // Geçersiz karakterleri kaldır
            title = Regex.Replace(title, @"[^a-z0-9\s-]", "");

            // Boşlukları tireye çevir
            title = Regex.Replace(title, @"\s+", "-").Trim('-');

            // Arka arkaya gelen tireleri teke indir
            title = Regex.Replace(title, "-{2,}", "-");

            return title;
        }
    }
}
