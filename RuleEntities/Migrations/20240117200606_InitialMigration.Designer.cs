﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RuleEntities;

#nullable disable

namespace RuleEntities.Migrations
{
    [DbContext(typeof(RuleContext))]
    [Migration("20240117200606_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ArmorEntityUnitEntity", b =>
                {
                    b.Property<long>("ArmorsId")
                        .HasColumnType("bigint");

                    b.Property<long>("UnitsId")
                        .HasColumnType("bigint");

                    b.HasKey("ArmorsId", "UnitsId");

                    b.HasIndex("UnitsId");

                    b.ToTable("ArmorEntityUnitEntity");
                });

            modelBuilder.Entity("RuleEntities.Entities.ArmorEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("armors");
                });

            modelBuilder.Entity("RuleEntities.Entities.BandEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Bands");
                });

            modelBuilder.Entity("RuleEntities.Entities.CloseCombatWeaponEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<long?>("UnitEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UnitEntityId");

                    b.ToTable("close_combat_weapons");
                });

            modelBuilder.Entity("RuleEntities.Entities.RangeWeaponEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.HasKey("Id");

                    b.ToTable("RangeWeapons");
                });

            modelBuilder.Entity("RuleEntities.Entities.SpecialRules.ArmorSpecialRuleEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("ArmorId")
                        .HasColumnType("bigint")
                        .HasColumnName("armor_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("ArmorId");

                    b.ToTable("armor_special_rules");
                });

            modelBuilder.Entity("RuleEntities.Entities.SpecialRules.BandSpecialRuleEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("BandId")
                        .HasColumnType("bigint")
                        .HasColumnName("band_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("BandId");

                    b.ToTable("band_special_rules");
                });

            modelBuilder.Entity("RuleEntities.Entities.UnitEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Attacks")
                        .HasColumnType("integer")
                        .HasColumnName("attacks");

                    b.Property<int>("BalisticSkill")
                        .HasColumnType("integer")
                        .HasColumnName("balistic_skill");

                    b.Property<long>("BandId")
                        .HasColumnType("bigint")
                        .HasColumnName("band_id");

                    b.Property<int>("Initiative")
                        .HasColumnType("integer")
                        .HasColumnName("initiative");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<int>("Leadership")
                        .HasColumnType("integer")
                        .HasColumnName("leadership");

                    b.Property<int>("MaxUnitCount")
                        .HasColumnType("integer")
                        .HasColumnName("max_unit_count");

                    b.Property<int>("Move")
                        .HasColumnType("integer")
                        .HasColumnName("move");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("Strength")
                        .HasColumnType("integer")
                        .HasColumnName("strength");

                    b.Property<int>("Toughest")
                        .HasColumnType("integer")
                        .HasColumnName("toughest");

                    b.Property<int>("UnitCost")
                        .HasColumnType("integer")
                        .HasColumnName("unit_cost");

                    b.Property<int>("WeaponSkill")
                        .HasColumnType("integer")
                        .HasColumnName("weapon_skill");

                    b.Property<int>("Woonds")
                        .HasColumnType("integer")
                        .HasColumnName("woonds");

                    b.HasKey("Id");

                    b.HasIndex("BandId");

                    b.ToTable("units");
                });

            modelBuilder.Entity("ArmorEntityUnitEntity", b =>
                {
                    b.HasOne("RuleEntities.Entities.ArmorEntity", null)
                        .WithMany()
                        .HasForeignKey("ArmorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuleEntities.Entities.UnitEntity", null)
                        .WithMany()
                        .HasForeignKey("UnitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RuleEntities.Entities.CloseCombatWeaponEntity", b =>
                {
                    b.HasOne("RuleEntities.Entities.UnitEntity", null)
                        .WithMany("CloseCombatWeapons")
                        .HasForeignKey("UnitEntityId");
                });

            modelBuilder.Entity("RuleEntities.Entities.SpecialRules.ArmorSpecialRuleEntity", b =>
                {
                    b.HasOne("RuleEntities.Entities.ArmorEntity", "Armor")
                        .WithMany("Rules")
                        .HasForeignKey("ArmorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Armor");
                });

            modelBuilder.Entity("RuleEntities.Entities.SpecialRules.BandSpecialRuleEntity", b =>
                {
                    b.HasOne("RuleEntities.Entities.BandEntity", "Band")
                        .WithMany("SpecialRules")
                        .HasForeignKey("BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Band");
                });

            modelBuilder.Entity("RuleEntities.Entities.UnitEntity", b =>
                {
                    b.HasOne("RuleEntities.Entities.BandEntity", "Band")
                        .WithMany("Units")
                        .HasForeignKey("BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Band");
                });

            modelBuilder.Entity("RuleEntities.Entities.ArmorEntity", b =>
                {
                    b.Navigation("Rules");
                });

            modelBuilder.Entity("RuleEntities.Entities.BandEntity", b =>
                {
                    b.Navigation("SpecialRules");

                    b.Navigation("Units");
                });

            modelBuilder.Entity("RuleEntities.Entities.UnitEntity", b =>
                {
                    b.Navigation("CloseCombatWeapons");
                });
#pragma warning restore 612, 618
        }
    }
}
