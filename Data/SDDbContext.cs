using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoundAndDance_v2.Data.Models;
using SoundAndDance_v2.Data.Models.Drums;
using SoundAndDance_v2.Data.Models.Bass;
using SoundAndDance_v2.Data.Models.Cases;
using SoundAndDance_v2.Data.Models.DJ;
using SoundAndDance_v2.Data.Models.Drums.DrumHardware;
using SoundAndDance_v2.Data.Models.GuitarAmpsAndCabs;
using SoundAndDance_v2.Data.Models.GuitarAndBassInstruments;
using SoundAndDance_v2.Data.Models.Keyboards;
using SoundAndDance_v2.Data.Models.Miscellaneous;
using SoundAndDance_v2.Data.Models.Orchestral;
using SoundAndDance_v2.Data.Models.Percussions;
using SoundAndDance_v2.Data.Models.Studio;
using SoundAndDance_v2.Data.Models.Transport;
using Microsoft.AspNetCore.Identity;

namespace SoundAndDance_v2.Data
{
    public class SDDbContext : IdentityDbContext<IdentityUser>
    {
        public SDDbContext(DbContextOptions<SDDbContext> options)
            : base(options)
        {
        }

        public DbSet<BassAmplifier> BassAmplifiers { get; set; }

        public DbSet<BassCabinet> BassCabinets { get; set; }

        public DbSet<BassCombo> BassCombos { get; set; }


        public DbSet<BassCase> BassCases { get; set; }

        public DbSet<BigCase> BigCases { get; set; }

        public DbSet<CymbalCase> CymbalCases { get; set; }

        public DbSet<DrumSmallCase> DrumSmallCases { get; set; }

        public DbSet<GuitarCase> GuitarCases { get; set; }

        public DbSet<HardCase> HardCases { get; set; }

        public DbSet<KeyboardCase> KeyboardCases { get; set; }

        public DbSet<OrganCase> OrganCases { get; set; }

        public DbSet<OtherCase> OtherCases { get; set; }

        public DbSet<PercussionCase> PercussionCases { get; set; }

        public DbSet<PianoShell> PianoShells { get; set; }



        public DbSet<DJMixer> DJMixers { get; set; }

        public DbSet<DJTable> DJTables { get; set; }


        public DbSet<AcousticDrumKit> AcousticDrumKits { get; set; }

        public DbSet<Cymbal> Cymbals { get; set; }

        public DbSet<DrumAccessory> DrumAccessories { get; set; }

        public DbSet<ElectronicDrumKit> ElectronicDrumKits { get; set; }

        public DbSet<Pad> Pads { get; set; }

        public DbSet<SnareDrum> SnareDrums { get; set; }


        public DbSet<CymbalStand> CymbalStands { get; set; }

        public DbSet<DrumHolder> DrumHolders { get; set; }

        public DbSet<DrumPedal> DrumPedals { get; set; }

        public DbSet<DrumRack> DrumRacks { get; set; }

        public DbSet<DrumStoolAndThrone> DrumStoolAndThrones { get; set; }

        public DbSet<HiHatStand> HiHatStands { get; set; }

        public DbSet<SnareStand> SnareStands { get; set; }

        public DbSet<TomStand> TomStands { get; set; }


        public DbSet<GuitarAmplifier> GuitarAmplifiers { get; set; }

        public DbSet<GuitarCabinet> GuitarCabinets { get; set; }

        public DbSet<GuitarCombo> GuitarCombos { get; set; }

        public DbSet<GuitarPedal> GuitarPedals { get; set; }

        public DbSet<GuitarStand> GuitarStands { get; set; }

        public DbSet<GuitarTuner> GuitarTuners { get; set; }


        public DbSet<AcousticGuitar> AcousticGuitars { get; set; }

        public DbSet<BassGuitar> BassGuitars { get; set; }

        public DbSet<DoubleBass> DoubleBasses { get; set; }

        public DbSet<ElectricGuitar> ElectricGuitars { get; set; }


        public DbSet<Keyboard> Keyboards { get; set; }

        public DbSet<KeyboardAmp> KeyboardAmps { get; set; }

        public DbSet<KeyboardPedal> KeyboardPedals { get; set; }

        public DbSet<KeyboardStand> KeyboardStands { get; set; }

        public DbSet<KeyboardStool> KeyboardStools { get; set; }

        public DbSet<MidiController> MidiControllers { get; set; }

        public DbSet<Organ> Organs { get; set; }

        public DbSet<PianoAndRoyal> PianoAndRoyals { get; set; }


        public DbSet<BarStool> BarStools { get; set; }

        public DbSet<BrassStand> BrassStands { get; set; }

        public DbSet<Cabel> Cabels { get; set; }

        public DbSet<Fan> Fans { get; set; }

        public DbSet<StandForNotesAndLights> StandForNotesAndLights { get; set; }

        public DbSet<Transformer> Transformers { get; set; }


        public DbSet<Orchestral> Orchestrals { get; set; }


        public DbSet<Bells> Bells { get; set; }

        public DbSet<Blocks> Blocks { get; set; }

        public DbSet<Bongos> Bongos { get; set; }

        public DbSet<Cabasa> Cabasas { get; set; }

        public DbSet<Cajon> Cajons { get; set; }

        public DbSet<Chimes> Chimes { get; set; }

        public DbSet<Claves> Claves { get; set; }

        public DbSet<Conga> Congas { get; set; }

        public DbSet<Cowbell> Cowbells { get; set; }

        public DbSet<Darabuka> Darabukas { get; set; }

        public DbSet<Djembe> Djembes { get; set; }

        public DbSet<Guiro> Guiros { get; set; }

        public DbSet<Maracases> Maracases { get; set; }

        public DbSet<OtherPercussion> OtherPercussions { get; set; }

        public DbSet<Shaker> Shakers { get; set; }

        public DbSet<Stand> Stands { get; set; }

        public DbSet<Table> Tables { get; set; }

        public DbSet<Tambourine> Tambourines { get; set; }

        public DbSet<Timbales> Timbales { get; set; }


        public DbSet<EarPhone> EarPhones { get; set; }

        public DbSet<Mic> Mics { get; set; }

        public DbSet<MixingConsole> MixingConsoles { get; set; }

        public DbSet<OtherInStudio> OtherInStudios { get; set; }

        public DbSet<Periphery> Peripheries { get; set; }


        public DbSet<Transport> Transports { get; set; }


        public DbSet<Categories> Categories { get; set; }

        public DbSet<Price> Prices { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost; User Id=sa; Password=reallyStrongPwd123; Database=SoundAndDance_v3");
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}