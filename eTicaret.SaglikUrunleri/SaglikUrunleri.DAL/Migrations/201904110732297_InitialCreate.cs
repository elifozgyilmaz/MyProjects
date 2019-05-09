namespace SaglikUrunleri.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alt Kategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AltKategoriAd = c.String(nullable: false, maxLength: 50),
                        kategoriID = c.Int(nullable: false),
                        Açıklama = c.String(),
                        Silindi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoriler", t => t.kategoriID)
                .Index(t => t.kategoriID);
            
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(),
                        Aciklama = c.String(),
                        Silindi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        urunKodu = c.String(nullable: false, maxLength: 20),
                        urunAd = c.String(nullable: false, maxLength: 50),
                        kategoriID = c.Int(nullable: false),
                        altKategoriID = c.Int(nullable: false),
                        miktar = c.Int(nullable: false),
                        kritikSeviye = c.Int(nullable: false),
                        urunFiyat = c.Decimal(nullable: false, storeType: "money"),
                        urunBilgisi = c.String(),
                        urunResimYolu1 = c.String(maxLength: 100),
                        urunResimYolu2 = c.String(maxLength: 100),
                        indirim = c.Boolean(nullable: false),
                        indirimOrani = c.Int(nullable: false),
                        Silindi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alt Kategoriler", t => t.altKategoriID)
                .ForeignKey("dbo.Kategoriler", t => t.kategoriID)
                .Index(t => t.kategoriID)
                .Index(t => t.altKategoriID);
            
            CreateTable(
                "dbo.SatisDetaylar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SatisID = c.Int(nullable: false),
                        UrunID = c.Int(nullable: false),
                        adet = c.Int(nullable: false),
                        birimFiyat = c.Decimal(nullable: false, storeType: "money"),
                        tutar = c.Decimal(nullable: false, storeType: "money"),
                        Silindi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Satis", t => t.SatisID)
                .ForeignKey("dbo.Urunler", t => t.UrunID)
                .Index(t => t.SatisID)
                .Index(t => t.UrunID);
            
            CreateTable(
                "dbo.Satis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tarih = c.DateTime(nullable: false),
                        uyeID = c.Int(nullable: false),
                        toplamMiktar = c.Decimal(nullable: false, storeType: "money"),
                        toplamTutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        teslimTarihi = c.DateTime(nullable: false),
                        durumu = c.Byte(nullable: false),
                        Silindi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Uye", t => t.uyeID)
                .Index(t => t.uyeID);
            
            CreateTable(
                "dbo.Uye",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ad = c.String(nullable: false, maxLength: 30),
                        soyad = c.String(nullable: false, maxLength: 30),
                        tckno = c.String(nullable: false, maxLength: 11),
                        adres = c.String(),
                        ilce = c.String(maxLength: 30),
                        il = c.String(maxLength: 30),
                        UserId = c.String(),
                        Silindi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 200),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Tarih = c.DateTime(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Alt Kategoriler", "kategoriID", "dbo.Kategoriler");
            DropForeignKey("dbo.SatisDetaylar", "UrunID", "dbo.Urunler");
            DropForeignKey("dbo.SatisDetaylar", "SatisID", "dbo.Satis");
            DropForeignKey("dbo.Satis", "uyeID", "dbo.Uye");
            DropForeignKey("dbo.Urunler", "kategoriID", "dbo.Kategoriler");
            DropForeignKey("dbo.Urunler", "altKategoriID", "dbo.Alt Kategoriler");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Satis", new[] { "uyeID" });
            DropIndex("dbo.SatisDetaylar", new[] { "UrunID" });
            DropIndex("dbo.SatisDetaylar", new[] { "SatisID" });
            DropIndex("dbo.Urunler", new[] { "altKategoriID" });
            DropIndex("dbo.Urunler", new[] { "kategoriID" });
            DropIndex("dbo.Alt Kategoriler", new[] { "kategoriID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Uye");
            DropTable("dbo.Satis");
            DropTable("dbo.SatisDetaylar");
            DropTable("dbo.Urunler");
            DropTable("dbo.Kategoriler");
            DropTable("dbo.Alt Kategoriler");
        }
    }
}
