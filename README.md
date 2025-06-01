# 💳 Fulbank

## 🧾 Description
Fulbank est un environnement de développement intégré destiné à la gestion des distributeurs automatiques de billets (DAB) pour une banque moderne.
Il permet le contrôle et la supervision de distributeurs prenant en charge à la fois la monnaie fiduciaire (euros, dollars) et la cryptomonnaie (Bitcoin, Ethereum).

## ⚙️ Installation
L’installation est simple et rapide grâce au fichier MSI fourni.

## 🔗 Télécharger
> 📦 [Télécharger Fulbank.msi (version 1.0)](https://github.com/NoaKorogu/FULBANK---Rito-Dev/releases/download/untagged-7e9e3ffab113eb3cdf7a/FulbankSetup.msi)

Une fois le fichier téléchargé :

Double-cliquez sur le fichier .msi.

Suivez les instructions de l’installateur.

Lancez l’application depuis le menu démarrer ou le raccourci sur le bureau.

## 📤 Dump de la base de données
Un fichier de dump SQL est disponible pour initialiser la base avec les structures et données de base nécessaires.

📄 [Télécharger le dump SQL](https://github.com/NoaKorogu/FULBANK---Rito-Dev/blob/main/Fulbank/Fulbank/Params/dump.sql)

## 📌 Instructions pour l'import :
Créez une base vide (ex. atm_ide_db) dans votre SGBD (MySQL).

```
mysql -u root -p atm_ide_db < chemin/vers/le_fichier_dump.sql
```

Lancez l’application et connectez-vous à cette base via le fichier Params/config.ini au sein de la solution.
