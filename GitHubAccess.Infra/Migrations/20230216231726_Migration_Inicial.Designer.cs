// <auto-generated />
using System;
using GitHubAccess.Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GitHubAccess.Infra.Migrations
{
    [DbContext(typeof(BdContexto))]
    [Migration("20230216231726_Migration_Inicial")]
    partial class Migration_Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GitHubAccess.Dominio.Entidades.GitHubRepositorio", b =>
                {
                    b.Property<bool?>("AllowAutoMerge")
                        .HasColumnType("bit");

                    b.Property<bool?>("AllowMergeCommit")
                        .HasColumnType("bit");

                    b.Property<bool?>("AllowRebaseMerge")
                        .HasColumnType("bit");

                    b.Property<bool?>("AllowSquashMerge")
                        .HasColumnType("bit");

                    b.Property<bool?>("AllowUpdateBranch")
                        .HasColumnType("bit");

                    b.Property<bool>("Archived")
                        .HasColumnType("bit");

                    b.Property<string>("CloneUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DefaultBranch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("DeleteBranchOnMerge")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Fork")
                        .HasColumnType("bit");

                    b.Property<int>("ForksCount")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GitUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasDownloads")
                        .HasColumnType("bit");

                    b.Property<bool>("HasIssues")
                        .HasColumnType("bit");

                    b.Property<bool>("HasPages")
                        .HasColumnType("bit");

                    b.Property<bool>("HasWiki")
                        .HasColumnType("bit");

                    b.Property<string>("Homepage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HtmlUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsTemplate")
                        .HasColumnType("bit");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MirrorUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NodeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OpenIssuesCount")
                        .HasColumnType("int");

                    b.Property<bool>("Private")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("PushedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.Property<string>("SshUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StargazersCount")
                        .HasColumnType("int");

                    b.Property<int>("SubscribersCount")
                        .HasColumnType("int");

                    b.Property<string>("SvnUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Topics")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WatchersCount")
                        .HasColumnType("int");

                    b.ToTable("GitHubRepositorio");
                });
#pragma warning restore 612, 618
        }
    }
}
