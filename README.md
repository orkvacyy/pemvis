# 💪 Hevy — Workout Tracker App
> Aplikasi desktop workout tracker berbasis **VB.NET Windows Forms** dengan koneksi database **MySQL**, terinspirasi dari aplikasi Hevy.

---

## 📋 Daftar Isi
- [Tentang Aplikasi](#tentang-aplikasi)
- [Fitur Utama](#fitur-utama)
- [Struktur Proyek](#struktur-proyek)
- [Konsep OOP yang Digunakan](#konsep-oop-yang-digunakan)
- [Arsitektur & Desain](#arsitektur--desain)
- [Konfigurasi & Setup](#konfigurasi--setup)
- [Skema Database](#skema-database)
- [Cara Menjalankan](#cara-menjalankan)

---

## Tentang Aplikasi

**Hevy** adalah aplikasi manajemen workout yang memungkinkan pengguna untuk:
- Membuat dan mengelola sesi workout
- Menambahkan exercise ke dalam setiap workout
- Mencatat set, repetisi, dan berat beban per exercise
- Mengelola library exercise custom (tambah, edit, hapus)
- Memfilter dan mencari exercise berdasarkan muscle group

---

## Fitur Utama

| Fitur | Deskripsi |
|-------|-----------|
| 📝 Workout Management | Buat, buka, edit, dan hapus workout |
| 🏋️ Exercise Library | Library exercise dengan filter muscle group |
| ➕ Custom Exercise | Tambah exercise baru dengan muscle group & equipment |
| 📊 Set Tracking | Catat weight, reps, dan status selesai per set |
| 🔍 Search & Filter | Cari exercise berdasarkan nama dan muscle group |

---

## Struktur Proyek

```
WindowsApp1/
├── App.config                  # Konfigurasi koneksi database
├── ConnectionModule.vb         # Module koneksi MySQL 
├── DataModule.vb               # Module CRUD semua entitas 
│
├── Form1.vb / .Designer.vb     # Main window (Workout list + Exercise library)
├── Form2.vb / .Designer.vb     # Tambah/edit custom exercise
├── Form3.vb / .Designer.vb     # Halaman detail workout (exercise + sets)
├── FormPickExercise.vb         # Picker exercise saat menambah ke workout
│
├── WorkoutCMS.vb               # UserControl: card workout
├── ExerciseCardCMS.vb          # UserControl: card exercise dalam workout
├── SetRowCMS.vb                # UserControl: baris satu set (weight, reps, dsb)
├── LibraryMasterCMS.vb         # UserControl: item exercise di library
│
├── My Project/
│   ├── Application.Designer.vb
│   ├── Resources.Designer.vb
│   └── Settings.Designer.vb
│
└── db_hevy/
    └── hevy_pemvis.sql         # Script SQL database
```

---

## Konsep OOP yang Digunakan

### 1. Encapsulation (Enkapsulasi)

Data dan perilaku dikemas di dalam class/module masing-masing. Field privat hanya bisa diakses melalui method publik.

**Contoh — `WorkoutCMS.vb`:**
```vb
Public Class WorkoutCMS
    Private _workoutId As Integer      ' Field privat, tidak bisa diakses langsung dari luar
    Private _workoutName As String

    ' Method publik sebagai satu-satunya cara mengisi data dari luar
    Public Sub SetData(id As Integer, name As String, ...)
        _workoutId = id
        _workoutName = name
        lblName.Text = name
    End Sub
End Class
```

**Contoh — `ExerciseCardCMS.vb`:**
```vb
Public Class ExerciseCardCMS
    Private _weId As Integer           ' ID workout_exercise, tersembunyi dari luar
    Private _exName As String

    Public Sub SetHeader(weId As Integer, exName As String, muscle As String)
        _weId = weId                   ' Set state internal lewat method publik
        lblName.Text = exName
    End Sub
End Class
```

---

### 2. Abstraction (Abstraksi)

Kompleksitas operasi database disembunyikan di balik method-method sederhana di `DataModule`. Pemanggil tidak perlu tahu bagaimana query SQL dijalankan.

**Contoh — `DataModule.vb`:**
```vb
' Pengguna cukup memanggil satu baris ini, tanpa perlu tahu SQL di dalamnya
Dim dt As DataTable = DataModule.getWorkouts()
Dim success As Boolean = DataModule.addExec(name, muscle, equipment)
```

Di balik layar, method tersebut mengelola koneksi, parameter SQL, dan error handling secara tersembunyi.

---

### 3. Inheritance (Pewarisan)

Seluruh Form dan UserControl mewarisi class bawaan .NET Framework, sehingga langsung mendapatkan semua fungsi form/control standar.

**Contoh — Form mewarisi `System.Windows.Forms.Form`:**
```vb
Public Class Form1
    ' Form1 mewarisi semua property dan method dari System.Windows.Forms.Form
    ' seperti: Show(), Close(), Controls, BackColor, dsb.
End Class
```

**Contoh — UserControl mewarisi `System.Windows.Forms.UserControl`:**
```vb
Public Class WorkoutCMS
    Inherits System.Windows.Forms.UserControl   ' (dideklarasikan di Designer.vb)
    ' Mendapat semua kemampuan control UI: Dock, Margin, Controls, dsb.
End Class
```

---

### 4. Events & Delegates (Event-Driven Programming)

Setiap UserControl mendefinisikan custom event untuk berkomunikasi dengan Form induk tanpa coupling langsung, mengikuti prinsip **loose coupling**.

**Contoh — `WorkoutCMS.vb`:**
```vb
Public Class WorkoutCMS
    ' Deklarasi custom event
    Public Event OpenClicked(workoutId As Integer)
    Public Event DeleteClicked(workoutId As Integer, workoutName As String)

    Private Sub btnOpen_Click(...) Handles btnOpen.Click
        RaiseEvent OpenClicked(_workoutId)   ' Kirim event ke Form induk
    End Sub
End Class
```

**Form induk (Form1.vb) menangkap event:**
```vb
AddHandler card.OpenClicked, Sub(clickedId)
    Dim f3 As New Form3()
    f3.InitWorkout(clickedId)
    f3.ShowDialog()
End Sub
```

---

### 5. 🔄 Modularisasi (Separation of Concerns)

Tanggung jawab dipisahkan ke dalam layer yang berbeda:

| Lapisan | File | Tanggung Jawab |
|---------|------|----------------|
| **Presentation Layer** | Form1, Form2, Form3, FormPickExercise | UI & interaksi pengguna |
| **Component Layer** | WorkoutCMS, ExerciseCardCMS, SetRowCMS, LibraryMasterCMS | Komponen UI reusable |
| **Data Access Layer** | DataModule.vb | Semua query SQL / CRUD |
| **Infrastructure Layer** | ConnectionModule.vb | Manajemen koneksi DB |
| **Configuration Layer** | App.config | Connection string terpusat |

---

### 6. Reusability melalui UserControl

UserControl dibuat sebagai komponen yang dapat digunakan ulang (*reusable components*). Satu UserControl bisa di-instansiasi berkali-kali untuk data yang berbeda.

**Contoh — `Form1.vb` membuat banyak instance `WorkoutCMS`:**
```vb
For Each row As DataRow In dt.Rows
    Dim card As New WorkoutCMS()   ' Satu instance per baris data
    card.SetData(wid, wName, wDate, exCount, setCount)
    flpWorkouts.Controls.Add(card)
Next
```

---

## Arsitektur & Desain

```
┌─────────────────────────────────────────────────────┐
│                   PRESENTATION LAYER                 │
│  Form1 (Main)  │  Form2 (Add/Edit Exercise)          │
│  Form3 (Workout Detail)  │  FormPickExercise          │
├─────────────────────────────────────────────────────┤
│                   COMPONENT LAYER                    │
│  WorkoutCMS  │  ExerciseCardCMS  │  SetRowCMS        │
│  LibraryMasterCMS                                    │
├─────────────────────────────────────────────────────┤
│                DATA ACCESS LAYER (DAL)               │
│              DataModule.vb (CRUD Methods)            │
├─────────────────────────────────────────────────────┤
│               INFRASTRUCTURE LAYER                   │
│    ConnectionModule.vb  │  App.config               │
├─────────────────────────────────────────────────────┤
│                   DATABASE                           │
│               MySQL — hevy_pemvis                    │
└─────────────────────────────────────────────────────┘
```

---

## Konfigurasi & Setup

### Prasyarat

- Visual Studio 2019 atau lebih baru
- .NET Framework 4.7.2
- MySQL Server (lokal/XAMPP)
- NuGet packages: `MySqlConnector 2.5.0`, `Guna.UI2.WinForms 2.0.4.7`

---

### Langkah 1 — Setup Database

1. Buka **phpMyAdmin** atau **MySQL Workbench**
2. Buat database baru dengan nama `hevy_pemvis`
3. Import file SQL yang tersedia:
   ```
   db_hevy/hevy_pemvis.sql
   ```
4. Pastikan semua tabel berhasil dibuat: `exercises`, `workouts`, `workout_exercises`, `workout_sets`

---

### Langkah 2 — Konfigurasi Connection String

Buka file `App.config` dan sesuaikan nilai koneksi database:

```xml
<connectionStrings>
    <add name="DefaultConnection"
         connectionString="Server=localhost;Database=hevy_pemvis;Uid=root;Pwd=;"
         providerName="MySqlConnector" />
</connectionStrings>
```

| Parameter | Default | Keterangan |
|-----------|---------|------------|
| `Server` | `localhost` | Host MySQL Anda |
| `Database` | `hevy_pemvis` | Nama database |
| `Uid` | `root` | Username MySQL |
| `Pwd` | *(kosong)* | Password MySQL (isi jika ada) |

---

### Langkah 3 — Tambahkan Referensi `System.Configuration` (Wajib)

Agar VB.NET dapat membaca file `App.config`, Anda harus mengaktifkan referensinya di Visual Studio:

1. Buka panel **Solution Explorer** di sebelah kanan
2. Klik kanan pada folder **References** (di bawah nama project `WindowsApp1`) → Pilih **Add Reference...**
3. Di jendela yang muncul, pilih tab **Assemblies** (atau Framework)
4. Scroll ke bawah dan cari `System.Configuration`
5. Centang kotak di sebelahnya, lalu klik **OK**

>  Setelah langkah ini, `ConfigurationManager.ConnectionStrings(...)` di `ConnectionModule.vb` akan berfungsi dengan benar.

---

### Langkah 4 — Install NuGet Packages

Buka **Package Manager Console** (Tools → NuGet Package Manager → Package Manager Console) dan jalankan:

```powershell
Install-Package MySqlConnector -Version 2.5.0
Install-Package Guna.UI2.WinForms -Version 2.0.4.7
```

Atau gunakan **NuGet Package Manager GUI** dan cari nama package di atas.

---

### Langkah 5 — Build & Run

1. Tekan `Ctrl + Shift + B` untuk Build Solution
2. Pastikan tidak ada error di Output window
3. Tekan `F5` untuk menjalankan aplikasi
4. Aplikasi akan terbuka di **Form1** (halaman utama Workout)

---

## Skema Database

```sql
exercises
├── id (PK, AUTO_INCREMENT)
├── name        VARCHAR(100)
├── muscle_group VARCHAR(50)
└── equipment   VARCHAR(50)

workouts
├── id (PK, AUTO_INCREMENT)
├── name        VARCHAR(100) DEFAULT 'New Workout'
├── date        DATETIME DEFAULT CURRENT_TIMESTAMP
└── notes       TEXT

workout_exercises
├── id (PK, AUTO_INCREMENT)
├── workout_id  → workouts.id (ON DELETE CASCADE)
├── exercise_id → exercises.id (ON DELETE CASCADE)
└── order_index INT

workout_sets
├── id (PK, AUTO_INCREMENT)
├── workout_exercise_id → workout_exercises.id (ON DELETE CASCADE)
├── set_number  INT
├── weight      DECIMAL(7,2)
├── reps        INT
└── completed   TINYINT(1)
```

Relasi menggunakan **Cascading Delete** — menghapus workout otomatis menghapus semua exercise dan set-nya.

---

## Cara Menjalankan

```
1. Clone / download project ini
2. Import hevy_pemvis.sql ke MySQL
3. Sesuaikan App.config (connection string)
4. Tambahkan referensi System.Configuration di Visual Studio
5. Install NuGet packages (MySqlConnector + Guna.UI2)
6. Build → Run (F5)
```

---

## Teknologi yang Digunakan

| Teknologi | Versi | Fungsi |
|-----------|-------|--------|
| VB.NET | - | Bahasa pemrograman utama |
| .NET Framework | 4.7.2 | Runtime |
| Windows Forms | - | Framework UI |
| MySQL | 8.0 | Database |
| MySqlConnector | 2.5.0 | Driver koneksi MySQL |
| Guna UI2 | 2.0.4.7 | Komponen UI modern  |

---

*Project ini dibuat sebagai implementasi aplikasi desktop VB.NET dengan penerapan konsep Object-Oriented Programming.*