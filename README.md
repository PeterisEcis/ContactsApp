# WinForms Kontakti

WinForms aplikācija, kas ļauj lietotājam pievienot, rediģēt un dzēst kontaktpersonas. Katras kontaktpersonas informācija tiek saglabāta SQLite datu bāzē, un lietotājam jābūt iespējai sinhronizēt šo informāciju ar Git.

## Funkcionalitāte:
Aplikācija atver galveno logu, kurā ir trīs galvenie pogas: "Pievienot", "Rediģēt" un "Dzēst".

![Galvenais skats](/screenshots/galvenais_skats.png?raw=true "Galvenais skats")

Kad lietotājs noklikšķina uz "Pievienot", parādās jauns logs, kurā lietotājs var ievadīt jaunas kontaktpersonas informāciju, piemēram, vārdu, uzvārdu, e-pasta adresi utt.

![Pievienot](/screenshots/pievienot.png?raw=true "Pievienot")

Kad lietotājs izvēlās kontaktu no saraksta un noklikšķina uz "Rediģēt", parādās līdzīgs logs kā "Pievienot", kurā ir iespējams labot informāciju par izvēlēto kontaktpersonu. Ir iespējams arī dubultklikšķis uz kontakta.

![Rediģēt](/screenshots/rediget.png?raw=true "Rediģēt")

Kad lietotājs izvēlās kontaktu no saraksta un noklikšķina uz "Dzēst", parādās logs ar kontaktpersonu sarakstu, no kura lietotājs var izvēlēties kontaktpersonu dzēšanai.
Pievienota papildus funkcionalitāte, ka ja kontaktam ir norādīts dzimšanas datums, tad kontakts iekrāsosies:
  - zaļš, ja dzimšanas diena būs šajā nedēļā;
  - rozā, ja dzimšanas diena ir šodien.

Šeit gan saskāros ar nelielu problēmu, ka iekrāsotie kontakti nemaina krāsu, ja tie tiek izvēlēti, līdz ar to ir grūti saprast vai tie ir izvēlēti. Diemžēl nepaspēju šo salabot.

![Dzimšanas dienas](/screenshots/dzimsanas_dienas.png?raw=true "Dzimšanas dienas")

Visu veikto darbību (pievienošana, rediģēšana, dzēšana) rezultātus saglabā SQLite datu bāzē. Datubāzes failu iespējams importēt un eksportēt lokāli. Importa funkcijas testam pievienoti [datubāzes piemēri](DatabaseExamples/) 

Lietotājam iespējams sinhronizēt veiktās izmaiņas ar Git. Lietotājam nepieciešams norādīt savu GitHub [Personal Access Token](https://docs.github.com/en/enterprise-server@3.9/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens), repozitorija URL un Git atzaru (branch). Tas ļauj gan saglabāt, gan lejupielādēt datubāzes failu.
Lai strādātu ar GitHub izmantoju Octokit Nuget package.

![Datu eksports](/screenshots/GithubExport.png?raw=true "Datu eksports")

![Datu imports](/screenshots/GitHubImport.png?raw=true "Datu imports")

Diemžēl pavadīju pārāk ilgu laiku cenšoties implementēt lietotājvārds/parole autentifikāciju, līdz uzgāju komentāram, ka šī autentifikācija vairs nestrādā, līdz ar to lai sinhronizētu datus ar GitHub nepieciešams kopēt PAT, kas nav ļoti parocīgi.
Vēl šobrīd kārtīgi nestrādā GitHub eksports, ja norādīts tukšs/tikko izveidots repozitorijs. Diemžēl atvēlētajā laikā neizdevās šo problēmu atrisināt, taču ja tiek izveidots Initial Commit pievienojot jebkādu failu (README, LICENCE, etc), tad pēc tam šo repozitoriju var izmantot datubāzes sinhronizācijai.
