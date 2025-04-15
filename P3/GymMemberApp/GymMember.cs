namespace GymMemberApp
{
    public class GymMember
    {
        public string Nama { get; set; }
        public int Umur { get; set; }
        public string JenisKelamin { get; set; }

        public override string ToString()
        {
            return $"{Nama} - {Umur} tahun - {JenisKelamin}";
        }
    }
}