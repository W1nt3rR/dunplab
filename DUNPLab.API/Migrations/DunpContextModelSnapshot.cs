﻿// <auto-generated />
using System;
using DUNPLab.API.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DUNPLab.API.Migrations
{
    [DbContext(typeof(DunpContext))]
    partial class DunpContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DUNPLab.API.Models.ATNotification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsSent")
                        .HasColumnType("bit");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdFile")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Sent")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdFile");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("DUNPLab.API.Models.EmailNotification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeOfSending")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("EmailNotifications");
                });

            modelBuilder.Entity("DUNPLab.API.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("JeLiObrisan")
                        .HasColumnType("bit");

                    b.Property<byte[]>("Sadrzaj")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("File");
                });
            modelBuilder.Entity("DUNPLab.API.Models.NotificationRecipient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("NotificationId")
                        .HasColumnType("int");

                    b.Property<string>("RecipientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NotificationId");

                    b.ToTable("Recipients");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Pacijent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojDokumenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DatumIstekaDokumenta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pacijenti");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adresa = "123 Main St",
                            BrojDokumenta = "AB123456",
                            DatumIstekaDokumenta = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DatumRodjenja = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "john.doe@example.com",
                            Grad = "Belgrade",
                            Ime = "John",
                            JMBG = "1234567890123",
                            Pol = "M",
                            Prezime = "Doe",
                            Telefon = "1234567890"
                        },
                        new
                        {
                            Id = 2,
                            Adresa = "456 Elm St",
                            BrojDokumenta = "CD987654",
                            DatumIstekaDokumenta = new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DatumRodjenja = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jane.doe@example.com",
                            Grad = "Novi Sad",
                            Ime = "Jane",
                            JMBG = "9876543210987",
                            Pol = "F",
                            Prezime = "Doe",
                            Telefon = "0987654321"
                });
                });

            modelBuilder.Entity("DUNPLab.API.Models.Rezultat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdSupstance")
                        .HasColumnType("int");

                    b.Property<int>("IdUzorka")
                        .HasColumnType("int");

                    b.Property<bool?>("JeLiUGranicama")
                        .HasColumnType("bit");

                    b.Property<bool>("Obradjen")
                        .HasColumnType("bit");

                    b.Property<double?>("Vrednost")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdSupstance");

                    b.HasIndex("IdUzorka");

                    b.ToTable("Rezultati");
                });

            modelBuilder.Entity("DUNPLab.API.Models.RezultatOdMasine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DatumVreme")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImeIPrezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("JesuLiPrebaceni")
                        .HasColumnType("bit");

                    b.Property<string>("KodEpruvete")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RezultatiOdMasine");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Supstanca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Cena")
                        .HasColumnType("float");

                    b.Property<double?>("DonjaGranica")
                        .HasColumnType("float");

                    b.Property<double?>("GornjaGranica")
                        .HasColumnType("float");

                    b.Property<string>("MetodTestiranja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oznaka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ZahtevId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZahtevId");

                    b.ToTable("Supstance");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cena = 100.0,
                            DonjaGranica = 0.10000000000000001,
                            GornjaGranica = 1.0,
                            MetodTestiranja = "Method 1",
                            Naziv = "Substance 1",
                            Opis = "Description for Substance 1",
                            Oznaka = "S1",
                            Tip = "Type 1"
                        },
                        new
                        {
                            Id = 2,
                            Cena = 200.0,
                            DonjaGranica = 0.20000000000000001,
                            GornjaGranica = 2.0,
                            MetodTestiranja = "Method 2",
                            Naziv = "Substance 2",
                            Opis = "Description for Substance 2",
                            Oznaka = "S2",
                            Tip = "Type 2"
                });
                });

            modelBuilder.Entity("DUNPLab.API.Models.Testiranje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BrojSobe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DatumVremeRezultata")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumVremeTestiranja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Izmenio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("IzmenioDatumVreme")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("JesuLiPotvrdjeniSviUzorci")
                        .HasColumnType("bit");

                    b.Property<string>("NacinPlacanja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestOdradio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("UkupnaCena")
                        .HasColumnType("float");

                    b.Property<int>("ZahtevId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Testiranja");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrojSobe = "101",
                            DatumVremeTestiranja = new DateTime(2023, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Izmenio = "Modifier 1",
                            IzmenioDatumVreme = new DateTime(2023, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            JesuLiPotvrdjeniSviUzorci = false,
                            NacinPlacanja = "Card",
                            Naziv = "Test 1",
                            Status = "In Progress",
                            TestOdradio = "Tester 1",
                            UkupnaCena = 300.0,
                            ZahtevId = 1
                        },
                        new
                        {
                            Id = 2,
                            BrojSobe = "102",
                            DatumVremeTestiranja = new DateTime(2023, 2, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Izmenio = "Modifier 2",
                            IzmenioDatumVreme = new DateTime(2023, 2, 1, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            JesuLiPotvrdjeniSviUzorci = false,
                            NacinPlacanja = "Cash",
                            Naziv = "Test 2",
                            Status = "In Progress",
                            TestOdradio = "Tester 2",
                            UkupnaCena = 400.0,
                            ZahtevId = 2
                });
                });

            modelBuilder.Entity("DUNPLab.API.Models.Uzorak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("Cena")
                        .HasColumnType("float");

                    b.Property<int>("IdTestiranja")
                        .HasColumnType("int");

                    b.Property<string>("Izmenio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("IzmenioDatumVreme")
                        .HasColumnType("datetime2");

                    b.Property<string>("KodEpruvete")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Komentar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KonacanRezultat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kutija")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetodTestiranja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdTestiranja");

                    b.ToTable("Uzorci");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cena = 100.0,
                            IdTestiranja = 1,
                            Izmenio = "Modifier 1",
                            IzmenioDatumVreme = new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            KodEpruvete = "E1",
                            Komentar = "Comment 1",
                            KonacanRezultat = "Result 1",
                            Kutija = "BX20230101000001",
                            MetodTestiranja = "Method 1",
                            Naziv = "Sample 1"
                        },
                        new
                        {
                            Id = 2,
                            Cena = 200.0,
                            IdTestiranja = 2,
                            Izmenio = "Modifier 2",
                            IzmenioDatumVreme = new DateTime(2023, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            KodEpruvete = "E2",
                            Komentar = "Comment 2",
                            KonacanRezultat = "Result 2",
                            Kutija = "BX20230201000002",
                            MetodTestiranja = "Method 2",
                            Naziv = "Sample 2"
                        });
                });

            modelBuilder.Entity("DUNPLab.API.Models.Zahtev", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DatumTestiranja")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("JeLiObradjen")
                        .HasColumnType("bit");

                    b.Property<string>("Metode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PacijentId")
                        .HasColumnType("int");

                    b.Property<int?>("TestiranjeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PacijentId");

                    b.HasIndex("TestiranjeId")
                        .IsUnique()
                        .HasFilter("[TestiranjeId] IS NOT NULL");

                    b.ToTable("Zahtevi");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DatumTestiranja = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JeLiObradjen = false,
                            Metode = "[]",
                            PacijentId = 1
                        },
                        new
                        {
                            Id = 2,
                            DatumTestiranja = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JeLiObradjen = false,
                            Metode = "[]",
                            PacijentId = 2
                        });
                });

            modelBuilder.Entity("DUNPLab.API.Models.ZahtevSubstanca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("SubstancaId")
                        .HasColumnType("int");

                    b.Property<int?>("ZahtevId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubstancaId");

                    b.HasIndex("ZahtevId");

                    b.ToTable("ZahtevSubstance");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SubstancaId = 1,
                            ZahtevId = 1
                        },
                        new
                        {
                            Id = 2,
                            SubstancaId = 2,
                            ZahtevId = 1
                        },
                        new
                        {
                            Id = 3,
                            SubstancaId = 1,
                            ZahtevId = 2
                        },
                        new
                        {
                            Id = 4,
                            SubstancaId = 2,
                            ZahtevId = 2
                        });
                });

                    modelBuilder.Entity("DUNPLab.API.Models.Rezultat", b =>
                        {
                            b.HasOne("DUNPLab.API.Models.Supstanca", "Supstanca")
                                .WithMany()
                                .HasForeignKey("IdSupstance")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();

                            b.HasOne("DUNPLab.API.Models.Uzorak", "Uzorak")
                                .WithMany("Rezultati")
                                .HasForeignKey("IdUzorka")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();

                            b.Navigation("Supstanca");

                            b.Navigation("Uzorak");
                        });

            modelBuilder.Entity("DUNPLab.API.Models.Supstanca", b =>
                {
                    b.HasOne("DUNPLab.API.Models.Zahtev", null)
                        .WithMany("Supstance")
                        .HasForeignKey("ZahtevId");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Uzorak", b =>
                {
                    b.HasOne("DUNPLab.API.Models.Testiranje", "Testiranje")
                        .WithMany("Uzorci")
                        .HasForeignKey("IdTestiranja")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Testiranje");
                });
            modelBuilder.Entity("DUNPLab.API.Models.VrednostOdMasine", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<bool>("JeLiBiloGreske")
                    .HasColumnType("bit");

                b.Property<string>("OznakaSubstance")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("RezultatOdMasineId")
                    .HasColumnType("int");

                b.Property<double>("Vrednost")
                    .HasColumnType("float");

                b.HasKey("Id");

                b.HasIndex("RezultatOdMasineId");

                b.ToTable("VrednostiOdMasine");
            });

            modelBuilder.Entity("DUNPLab.API.Models.VrednostOdMasine", b =>
            {
                b.HasOne("DUNPLab.API.Models.RezultatOdMasine", "RezultatOdMasine")
                    .WithMany("VrednostiOdMasine")
                    .HasForeignKey("RezultatOdMasineId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("RezultatOdMasine");
            });

            modelBuilder.Entity("DUNPLab.API.Models.RezultatOdMasine", b =>
            {
                b.Navigation("VrednostiOdMasine");
            });

            modelBuilder.Entity("DUNPLab.API.Models.Zahtev", b =>
                {
                    b.HasOne("DUNPLab.API.Models.Pacijent", "Pacijent")
                        .WithMany()
                        .HasForeignKey("PacijentId");

                    b.HasOne("DUNPLab.API.Models.Testiranje", "Testiranje")
                        .WithOne("Zahtev")
                        .HasForeignKey("DUNPLab.API.Models.Zahtev", "TestiranjeId");

                    b.Navigation("Pacijent");

                    b.Navigation("Testiranje");
                });

            modelBuilder.Entity("DUNPLab.API.Models.ZahtevSubstanca", b =>
                {
                    b.HasOne("DUNPLab.API.Models.Supstanca", "Supstanca")
                        .WithMany("ZahtevSupstance")
                        .HasForeignKey("SubstancaId");

                    b.HasOne("DUNPLab.API.Models.Zahtev", "Zahtev")
                        .WithMany("ZahtevSupstance")
                        .HasForeignKey("ZahtevId");

                    b.Navigation("Supstanca");

                    b.Navigation("Zahtev");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Supstanca", b =>
                {
                    b.Navigation("ZahtevSupstance");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Testiranje", b =>
                {
                    b.Navigation("Uzorci");

                    b.Navigation("Zahtev")
                        .IsRequired();
                });

            modelBuilder.Entity("DUNPLab.API.Models.Uzorak", b =>
                {
                    b.Navigation("Rezultati");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Zahtev", b =>
                {
                    b.Navigation("Supstance");

                    b.Navigation("ZahtevSupstance");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Email", b =>
                {
                    b.HasOne("DUNPLab.API.Models.File", "File")
                        .WithMany()
                        .HasForeignKey("IdFile");

                    b.Navigation("File");
                });

            modelBuilder.Entity("DUNPLab.API.Models.NotificationRecipient", b =>
                {
                    b.HasOne("DUNPLab.API.Models.ATNotification", "Notification")
                        .WithMany("Recipients")
                        .HasForeignKey("NotificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Notification");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Zahtev", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DatumTestiranja")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("JeLiObradjen")
                        .HasColumnType("bit");

                    b.Property<string>("Metode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PacijentId")
                        .HasColumnType("int");

                    b.Property<int?>("TestiranjeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PacijentId");

                    b.HasIndex("TestiranjeId");

                    b.ToTable("Zahtevi");
                });

            modelBuilder.Entity("DUNPLab.API.Models.NotificationRecipient", b =>
                {
                    b.HasOne("DUNPLab.API.Models.ATNotification", "Notification")
                        .WithMany("Recipients")
                        .HasForeignKey("NotificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Notification");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Rezultat", b =>
                {
                    b.HasOne("DUNPLab.API.Models.Supstanca", "Supstanca")
                        .WithMany()
                        .HasForeignKey("IdSupstance")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DUNPLab.API.Models.Uzorak", "Uzorak")
                        .WithMany("Rezultati")
                        .HasForeignKey("IdUzorka")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supstanca");

                    b.Navigation("Uzorak");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Supstanca", b =>
                {
                    b.HasOne("DUNPLab.API.Models.Zahtev", null)
                        .WithMany("Supstance")
                        .HasForeignKey("ZahtevId");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Uzorak", b =>
                {
                    b.HasOne("DUNPLab.API.Models.Testiranje", "Testiranje")
                        .WithMany("Uzorci")
                        .HasForeignKey("IdTestiranja")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Testiranje");
                });

            modelBuilder.Entity("DUNPLab.API.Models.VrednostOdMasine", b =>
                {
                    b.HasOne("DUNPLab.API.Models.RezultatOdMasine", "RezultatOdMasine")
                        .WithMany("VrednostiOdMasine")
                        .HasForeignKey("RezultatOdMasineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RezultatOdMasine");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Zahtev", b =>
                {
                    b.HasOne("DUNPLab.API.Models.Pacijent", "Pacijent")
                        .WithMany()
                        .HasForeignKey("PacijentId");

                    b.HasOne("DUNPLab.API.Models.Testiranje", "Testiranje")
                        .WithMany()
                        .HasForeignKey("TestiranjeId");

                    b.Navigation("Pacijent");

                    b.Navigation("Testiranje");
                });

            modelBuilder.Entity("DUNPLab.API.Models.ATNotification", b =>
                {
                    b.Navigation("Recipients");
                });

            modelBuilder.Entity("DUNPLab.API.Models.RezultatOdMasine", b =>
                {
                    b.Navigation("VrednostiOdMasine");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Testiranje", b =>
                {
                    b.Navigation("Uzorci");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Uzorak", b =>
                {
                    b.Navigation("Rezultati");
                });

            modelBuilder.Entity("DUNPLab.API.Models.Zahtev", b =>
                {
                    b.Navigation("Supstance");
                });
#pragma warning restore 612, 618
        }
    }
}
