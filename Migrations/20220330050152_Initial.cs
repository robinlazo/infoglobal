using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CountryList.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Continents",
                columns: table => new
                {
                    ContinentID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continents", x => x.ContinentID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ImageFlag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Population = table.Column<int>(type: "int", nullable: false),
                    ContinentID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countries_Continents_ContinentID",
                        column: x => x.ContinentID,
                        principalTable: "Continents",
                        principalColumn: "ContinentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "ContinentID", "Name" },
                values: new object[,]
                {
                    { "africa", "Africa" },
                    { "america", "America" },
                    { "asia", "Asia" },
                    { "europe", "Europe" },
                    { "oceania", "Oceania" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "City", "ContinentID", "ImageFlag", "Name", "Population" },
                values: new object[,]
                {
                    { "ad", "Andorra la vieja", "europe", "ad.png", "Andorra", 85660 },
                    { "ae", "Abu Dabi", "asia", "ae.png", "Emiratos Arabes Unidos", 5927482 },
                    { "af", "Kabul", "asia", "af.png", "Afganistan", 33332025 },
                    { "ag", "Saint John's", "america", "ag.png", "Antigua y Barbuda", 95581 },
                    { "al", "Tirana", "europe", "al.png", "Albania", 3038594 },
                    { "am", "Erevan", "europe", "am.png", "Armenia", 3229900 },
                    { "ao", "Luanda", "africa", "ao.png", "Angola", 20172332 },
                    { "ar", "Buenos Aires", "america", "ar.png", "Argentina", 45030748 },
                    { "at", "Viena", "europe", "at.png", "Austria", 8711770 },
                    { "au", "Canberra", "oceania", "au.png", "Australia", 20172332 },
                    { "az", "Baku", "europe", "az.png", "Azerbaiyan", 9872765 },
                    { "ba", "Zarajevo", "europe", "ba.png", "Bosnia y Herzegovina", 3861912 },
                    { "bb", "Bridgetown", "america", "bb.png", "Barbados", 292495 },
                    { "bd", "Daca", "asia", "bd.png", "Bangladesh", 156186882 },
                    { "be", "Bruselas", "europe", "be.png", "Belgica", 11409077 },
                    { "bf", "Uagadugu", "africa", "bf.png", "Burkina Faso", 19512533 },
                    { "bg", "Sofia", "europe", "bg.png", "Bulgaria", 7144653 },
                    { "bh", "Manama", "asia", "bh.png", "Bahrein", 1378904 },
                    { "bi", "Gitega", "africa", "bi.png", "Burundi", 11099298 },
                    { "bj", "Porto Novo", "africa", "bj.png", "Benin", 10741458 },
                    { "bn", "Bandar Seri Begawan", "asia", "bn.png", "Brunei", 436620 },
                    { "bo", "Sucre", "america", "bo.png", "Bolivia", 11969649 },
                    { "br", "Brasilia", "america", "br.png", "Brasil", 211823665 },
                    { "bs", "Nasau", "america", "bs.png", "Bahamas", 328316 },
                    { "bt", "Timbu", "asia", "bt.png", "Butan", 750125 },
                    { "bw", "Gaborone", "africa", "bw.png", "Botsuana", 2209208 },
                    { "by", "Minsk", "europe", "by.png", "Bielorussia", 9570376 },
                    { "bz", "Belmopan", "america", "bz.png", "Belize", 397621 },
                    { "ca", "Ottawa", "america", "ca.png", "Canada", 38010000 },
                    { "cd", "Kinsasa", "africa", "cd.png", "Republica Democratica Del Congo", 8133105 },
                    { "cf", "Bangui", "africa", "cf.png", "Republica Centroafricana", 5507257 },
                    { "cg", "Brazzaville", "africa", "cg.png", "Republica Del Congo", 4852412 },
                    { "ch", "Berna", "europe", "ch.png", "Suiza", 8179294 },
                    { "ci", "Yamusukro", "africa", "ci.png", "Costa de Marfil", 23740424 },
                    { "cl", "Santiago", "america", "cl.png", "Chile", 18650114 },
                    { "cm", "Yaunde", "africa", "cm.png", "Camerun", 24360803 },
                    { "cn", "Pekin", "asia", "cn.png", "China", 1373541278 },
                    { "co", "Bogota", "america", "co.png", "Colombia", 51049498 },
                    { "cr", "San Jose", "america", "cr.png", "Costa Rica", 5094000 },
                    { "cu", "Habana", "america", "cu.png", "Cuba", 11330000 },
                    { "cv", "Praia", "africa", "cv.png", "Cabo Verde", 553432 },
                    { "cw", "Willemstad", "america", "cw.png", "Curazao", 154843 }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "City", "ContinentID", "ImageFlag", "Name", "Population" },
                values: new object[,]
                {
                    { "cz", "Praga", "europe", "cz.png", "Republica Checa", 10644842 },
                    { "de", "Berlin", "europe", "de.png", "Alemania", 80722792 },
                    { "dj", "Yibuti City", "africa", "dj.png", "Yibuti", 846687 },
                    { "dk", "Copenhague", "europe", "dk.png", "Dinamarca", 5593785 },
                    { "dm", "Roseau", "america", "dm.png", "Dominica", 74757 },
                    { "do", "Santo Domingo", "america", "do.png", "Republic Dominican", 10850000 },
                    { "dz", "Argel", "africa", "dz.png", "Argelia", 40263711 },
                    { "ec", "Quito", "america", "ec.png", "Ecuador", 17080778 },
                    { "ee", "Tallin", "europe", "ee.png", "Estonia", 1258545 },
                    { "eg", "El Cairo", "africa", "eg.png", "Egipto", 94666993 },
                    { "er", "Asmara", "africa", "er.png", "Eritrea", 5869869 },
                    { "es", "Madrid", "europe", "es.png", "España", 48563476 },
                    { "et", "Adis Abeba", "africa", "et.png", "Etiopia", 102374044 },
                    { "fi", "Helsinki", "europe", "fi.png", "Finlandia", 5948211 },
                    { "fj", "Suva", "oceania", "fj.png", "Fiyi", 915303 },
                    { "fm", "Palikir", "oceania", "fm.png", "Micronesia", 104719 },
                    { "fr", "Paris", "europe", "fr.png", "Francia", 66836154 },
                    { "ga", "Libreville", "africa", "ga.png", "Gabon", 1738541 },
                    { "gb", "Londres", "europe", "gb.png", "Reino Unido", 64430428 },
                    { "gd", "Saint George", "america", "gd.png", "Granada", 111229 },
                    { "ge", "Tiflis", "europe", "ge.png", "Georgia", 4928052 },
                    { "gh", "Acra", "africa", "gh.png", "Ghana", 26908262 },
                    { "gm", "Banjul", "africa", "gm.png", "Gambia", 2009648 },
                    { "gn", "Conakri", "africa", "gn.png", "Guinea", 12093349 },
                    { "gq", "Malabo", "africa", "gq.png", "Guinea Ecuatorial", 759451 },
                    { "gr", "Atenas", "europe", "gr.png", "Grecia", 10773253 },
                    { "gt", "Guatemala City", "america", "gt.png", "Guatemala", 16860000 },
                    { "gw", "Bisau", "africa", "gw.png", "Guinea-Bisau", 1759159 },
                    { "gy", "Georgetown", "america", "gy.png", "Guyana", 1035000 },
                    { "hn", "Tegucigalpa", "america", "hn.png", "Honduras", 9905000 },
                    { "hr", "Zagreb", "europe", "hr.png", "Croacia", 4313707 },
                    { "ht", "Puerto Principe", "america", "ht.png", "Haiti", 11400000 },
                    { "hu", "Budapest", "europe", "hu.png", "Hungria", 9874784 },
                    { "id", "Jakarta", "asia", "id.png", "Indonesia", 258316051 },
                    { "ie", "Dublin", "europe", "ie.png", "Irlanda", 4952473 },
                    { "il", "Jerusalen", "asia", "il.png", "Israel", 8174527 },
                    { "in", "Nueva Delhi", "asia", "in.png", "India", 1266883598 },
                    { "iq", "Bagdad", "asia", "iq.png", "Irak", 38146025 },
                    { "ir", "Teheran", "asia", "ir.png", "Iran", 82801633 },
                    { "is", "Reikiavic", "europe", "is.png", "Islandia", 335878 },
                    { "it", "Roma", "europe", "it.png", "Italia", 62007540 },
                    { "jm", "Kingston", "america", "jm.png", "Jamaica", 2961000 }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "City", "ContinentID", "ImageFlag", "Name", "Population" },
                values: new object[,]
                {
                    { "jo", "Aman", "asia", "jo.png", "Jordania", 8185384 },
                    { "jp", "Tokio", "asia", "jp.png", "Japon", 126702133 },
                    { "ke", "Nairobi", "africa", "ke.png", "Kenia", 46790758 },
                    { "kg", "Biskek", "asia", "kg.png", "Kirguistan", 5727553 },
                    { "kh", "Nom Pen", "asia", "kh.png", "Camboya", 15957223 },
                    { "ki", "Tarawa", "oceania", "ki.png", "Kiribati", 106925 },
                    { "km", "Moroni", "africa", "km.png", "Comoras", 794678 },
                    { "kn", "Basseterre", "america", "kn.png", "San Cristobal y Nieves", 53329 },
                    { "kp", "Pionyang", "asia", "kp.png", "Corea Del Norte", 25115311 },
                    { "kr", "Seul", "asia", "kr.png", "Corea Del Sur", 50924172 },
                    { "kw", "Kuwait City", "asia", "kw.png", "Kuwait", 2832776 },
                    { "kz", "Astana", "asia", "kz.png", "Kazajistan", 18360353 },
                    { "la", "Vientian", "asia", "la.png", "Laos", 7019073 },
                    { "lb", "Beirut", "asia", "lb.png", "Libano", 6237738 },
                    { "lc", "Castries", "america", "lc.png", "Santa Lucia", 167464 },
                    { "li", "Vaduz", "europe", "li.png", "Liechtenstein", 37937 },
                    { "lk", "Sri Jayawardenapura Kotte", "asia", "lk.png", "Sri Lanka", 22235000 },
                    { "lr", "Monrovia", "africa", "lr.png", "Liberia", 4299944 },
                    { "ls", "Maseru", "africa", "ls.png", "Lesoto", 1953070 },
                    { "lt", "Vilda", "europe", "lt.png", "Lituania", 2854235 },
                    { "lu", "Luxemburgo City", "europe", "lu.png", "Luxemburgo", 582291 },
                    { "lv", "Riga", "europe", "lv.png", "Letonia", 1965686 },
                    { "ly", "Tripoli", "africa", "ly.png", "Libia", 6541948 },
                    { "mc", "Monaco City", "europe", "mc.png", "Monaco", 30581 },
                    { "md", "Chisinau", "europe", "md.png", "Moldavia", 3510485 },
                    { "me", "Podgorica", "europe", "me.png", "Montenegro", 644578 },
                    { "mg", "Antananarivo", "africa", "mg.png", "Madagascar", 24430325 },
                    { "mh", "Majuro", "oceania", "mh.png", "Islas Marshall", 73376 },
                    { "mk", "Skopie", "europe", "mk.png", "Macedonia", 2100025 },
                    { "ml", "Bamako", "africa", "ml.png", "Mali", 17467108 },
                    { "mm", "Naipyido", "asia", "mm.png", "Birmania", 56890418 },
                    { "mn", "Ulán Bator", "asia", "mn.png", "Mongolia", 3031330 },
                    { "mr", "Nuakchot", "africa", "mr.png", "Mauritania", 3677293 },
                    { "mt", "La Valeta", "europe", "mt.png", "Malta", 415196 },
                    { "mu", "Port Louis", "africa", "mu.png", "Mauricio", 1348242 },
                    { "mv", "Male", "asia", "mv.png", "Maldivas", 317960 },
                    { "mw", "Lilongue", "africa", "mw.png", "Malaui", 18570321 },
                    { "mx", "Mexico City", "america", "mx.png", "Mexico", 128900000 },
                    { "my", "Kuala Lumpur", "asia", "my.png", "Malasia", 30949962 },
                    { "mz", "Maputo", "africa", "mz.png", "Mozambique", 25930150 },
                    { "na", "Windhoek", "africa", "na.png", "Namibia", 2436469 },
                    { "ne", "Niamey", "africa", "ne.png", "Niger", 18638600 }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "City", "ContinentID", "ImageFlag", "Name", "Population" },
                values: new object[,]
                {
                    { "ng", "Abuya", "africa", "ng.png", "Nigeria", 186053386 },
                    { "ni", "Managua", "america", "ni.png", "Nicaragua", 6625000 },
                    { "nl", "Amsterdam", "europe", "nl.png", "Holanda", 17016967 },
                    { "no", "Oslo", "europe", "no.png", "Noruega", 5265158 },
                    { "np", "Katmandu", "asia", "np.png", "Nepal", 29033914 },
                    { "nr", "Yaren", "oceania", "nr.png", "Nauru", 9591 },
                    { "nz", "Wellington", "oceania", "nz.png", "Nueva Zelanda", 4474549 },
                    { "om", "Mascate", "asia", "om.png", "Oman", 3355262 },
                    { "pa", "Panama City", "america", "pa.png", "Panama", 4315000 },
                    { "pg", "Puerto Moresby", "oceania", "pg.png", "Papua Nueva Guinea", 6791317 },
                    { "pk", "Islamabad", "asia", "pk.png", "Pakistan", 201995540 },
                    { "pl", "Varsovia", "europe", "pl.png", "Polonia", 38652326 },
                    { "pr", "San Juan", "america", "pr.png", "Puerto Rico", 3194000 },
                    { "pt", "Lisboa", "europe", "pt.png", "Portugal", 10833816 },
                    { "pw", "Ngerulmud", "oceania", "pw.png", "Palaos", 21347 },
                    { "py", "Asuncion", "america", "py.png", "Paraguay", 7162812 },
                    { "qa", "Doha", "asia", "qa.png", "Catar", 2258283 },
                    { "ro", "Bucarest", "europe", "ro.png", "Rumania", 21599736 },
                    { "rs", "Belgrado", "europe", "rs.png", "Serbia", 7143921 },
                    { "ru", "Moscu", "europe", "ru.png", "Rusia", 142355415 },
                    { "rw", "Kigali", "africa", "rw.png", "Ruanda", 12988423 },
                    { "sa", "Riad", "asia", "sa.png", "Arabia Saudita", 28160273 },
                    { "sb", "Honiara", "oceania", "sb.png", "Islas Salomon", 635027 },
                    { "sc", "Victoria", "africa", "sc.png", "Seychelles", 93186 },
                    { "sd", "Jartum", "africa", "sd.png", "Sudan", 36729501 },
                    { "se", "Estocolmo", "europe", "se.png", "Suecia", 9880604 },
                    { "sg", "Singapur City", "asia", "sg.png", "Singapur", 5781728 },
                    { "si", "Liubliana", "europe", "si.png", "Eslovenia", 1978029 },
                    { "sk", "Bratislava", "europe", "sk.png", "Eslovaquia", 5445802 },
                    { "sl", "Free Town", "africa", "sl.png", "Sierra Leona", 6018888 },
                    { "sm", "San Marico City", "europe", "sm.png", "San Marino", 33285 },
                    { "sn", "Dakar", "africa", "sn.png", "Senegal", 14320055 },
                    { "so", "Mogadiscio", "africa", "so.png", "Somalia", 10817354 },
                    { "sr", "Paramaribo", "america", "sr.png", "Surinam", 595894 },
                    { "ss", "Yuba", "africa", "ss.png", "Sudan Del Sur", 12530717 },
                    { "st", "Santo Tome", "africa", "st.png", "Santo Tome y Principe", 197541 },
                    { "sv", "San Salvador", "america", "sv.png", "El Salvador", 6500000 },
                    { "sy", "Damasco", "asia", "sy.png", "Siria", 17185170 },
                    { "sz", "Mbabane", "africa", "sz.png", "Suazilandia", 1451428 },
                    { "td", "Yamena", "africa", "td.png", "Chad", 11852462 },
                    { "tg", "Lome", "africa", "tg.png", "Togo", 7756937 },
                    { "th", "Bangkok", "asia", "th.png", "Tailandia", 68200884 }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "City", "ContinentID", "ImageFlag", "Name", "Population" },
                values: new object[,]
                {
                    { "tl", "Dili", "asia", "tl.png", "Timor Oriental", 1261072 },
                    { "tn", "Tunez City", "africa", "tn.png", "Tunez", 11134588 },
                    { "to", "Nukualofa", "oceania", "to.png", "Tonga", 106513 },
                    { "tt", "Puerto Espana", "america", "tt.png", "Trinidad y Tobago", 1320479 },
                    { "tv", "Funafuti", "oceania", "tv.png", "Tuvalu", 10959 },
                    { "tw", "Taipei", "asia", "tw.png", "Taiwan", 23464787 },
                    { "tz", "Dodoma", "africa", "tz.png", "Tanzania", 52482726 },
                    { "ua", "Kiev", "europe", "ua.png", "Ucrania", 44209733 },
                    { "ug", "Kampala", "africa", "ug.png", "Uganda", 38319241 },
                    { "us", "Washington D.C", "america", "us.png", "Estados Unidos", 329500000 },
                    { "uy", "Montevideo", "america", "uy.png", "Uruguay", 3286314 },
                    { "uz", "Asjabad", "asia", "uz.png", "Turkmenistan", 5291317 },
                    { "va", "Vatican City", "europe", "va.png", "Vaticano", 1000 },
                    { "vc", "Kingstown", "america", "vc.png", "San Vicente y Las Granadinas", 106350 },
                    { "ve", "Caracas", "america", "ve.png", "Venezuela", 28500302 },
                    { "vn", "Hanoi", "asia", "vn.png", "Vietnam", 95261021 },
                    { "vu", "Port Vila", "oceania", "vu.png", "Vanuatu", 277554 },
                    { "ws", "Apia", "oceania", "ws.png", "Samoa", 198926 },
                    { "ye", "Sana", "asia", "ye.png", "Yemen", 27392779 },
                    { "za", "Pretoria Ciudad del Cabo Bloemfontein", "africa", "za.png", "Sudafrica", 54300704 },
                    { "zm", "Lusaka", "africa", "zm.png", "Zambia", 15510711 },
                    { "zw", "Harare", "africa", "zw.png", "Zimbabue", 14546961 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_ContinentID",
                table: "Countries",
                column: "ContinentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Continents");
        }
    }
}
