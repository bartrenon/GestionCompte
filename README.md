# GestionCompte

Une application console C# pour la gestion de comptes bancaires et transactions financières.

## 📋 Description

GestionCompte est une application de gestion bancaire développée en C# (.NET 8.0) qui permet de gérer différents types de comptes (Épargne et Courant) avec des opérations de dépôt, retrait, et application d'intérêts.

## 🏗️ Architecture du Projet

Le projet suit une architecture orientée objet avec les principes de séparation des responsabilités :


## 🔧 Technologie

- **Langage** : C# 12
- **Framework** : .NET 8.0
- **Type de projet** : Application Console

## 📦 Configuration du Projet

Le projet utilise .NET 8.0 avec les fonctionnalités suivantes activées :
- **ImplicitUsings** : Activé (utilisation automatique des using courants)
- **Nullable** : Activé (support du contexte nullable)

## 🎯 Fonctionnalités

### Classes Métier

#### **Personne**
Représente un titulaire de compte avec :
- Nom
- Prénom
- Date de naissance

#### **Compte** (Classe abstraite)
Classe de base pour tous les types de comptes avec :
- Numéro de compte (identifiant unique)
- Solde
- Date d'ouverture
- Titulaire (Personne)

#### **Epargne**
Compte d'épargne avec :
- Héritage de Compte
- Application d'intérêts (interface IBanker)
- Opérations de dépôt/retrait (interface ICustomer)

#### **Courant**
Compte courant avec :
- Héritage de Compte
- **Ligne de crédit** : montant maximum de découvert autorisé
- Vérification lors du retrait
- Application d'intérêts (interface IBanker)
- Opérations de dépôt/retrait (interface ICustomer)

### Interfaces

#### **ICustomer**
Contrat pour les opérations clients :
- `Depot(montant)` : Effectuer un dépôt
- `Retrait(montant)` : Effectuer un retrait
- Propriété `solde` : Accès en lecture au solde

#### **IBanker**
Contrat pour les opérations bancaires :
- `Depot(montant)` : Effectuer un dépôt
- `Retrait(montant)` : Effectuer un retrait
- `AppliquerInteret()` : Appliquer les intérêts
- Propriétés : `solde`, `numero`, `titulaire`

### Gestion des Exceptions

#### **SoldeInsuffisantException**
Exception levée lorsque :
- Un montant de retrait dépasse le solde disponible
- Une ligne de crédit négative est tentée

