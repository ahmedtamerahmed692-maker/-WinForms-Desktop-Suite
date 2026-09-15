# 🚀 WinForms Desktop Suite

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-purple.svg)](https://dotnet.microsoft.com/)
[![Language](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-Windows-0078D6.svg)](https://www.microsoft.com/windows)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

مجموعة تطبيقات وأدوات سطح مكتب متكاملة تم تطويرها بلغة **C#** باستخدام تقنية **Windows Forms (.NET Framework 4.8)**. تجمع الحلول المبتكرة بين إدارة المهام اليومية، وحساب العمر الدقيق، وأذكار تسبيح وتذكير آلي، والتفاعل مع الواجهات.

---

## 🌟 الميزات والأدوات المضمنة (Features & Modules)

### 1️⃣ **برنامج إدارة المهام (Task Manager / To-Do List) - `Form2`**
* ➕ **إضافة المهام**: إضافة مهام جديدة إلى القائمة بسهولة وسرعة.
* ✔️ **تحديد وإنجاز المهام**: وضع علامة إنجاز (Done) على المهام المحددة.
* 📊 **عدادات حية**: تحديث فوري وتلقائي لعدد المهام المتبقية (`Pending`) والمهام المكتملة (`Completed`).
* 🔘 **التحكم الجماعي**: أزرار مخصصة لـ "تحديد الكل" (Select All) و "إلغاء تحديد الكل" (Unselect All).
* 🗑️ **إزالة المهام**: حذف المهام المحددة أو المكتملة بأمان.

---

### 2️⃣ **حاسبة العمر الدقيقة (Age Calculator) - `Form3`**
* 📅 **اختيار التاريخ**: استخدام عنصر `DateTimePicker` لاختيار تاريخ الميلاد بسلاسة.
* 🧮 **حساب دقيق متعدد الأبعاد**:
  * حساب العمر **بالسنوات** (Years).
  * حساب العمر **بالشهور الكلية** (Months).
  * حساب العمر **بالأيام الكلية** (Days).
* 🛡️ **حماية التواريخ المستقبلية**: منع الأرقام السالبة عند اختيار تاريخ في المستقبل.

---

### 3️⃣ **مؤقت الأذكار التلقائي والواجهات التفاعلية - `Form1`**
* 🤲 **مؤقت الأذكار الآلي (Automated Azkar Timer)**:
  * يتغير الذكر تلقائياً كل 30 ثانية بالتتابع: **`سبحان الله`** ⬅️ **`الحمد لله`** ⬅️ **`الله أكبر`**.
  * أزرار تشغيل وإيقاف (**Start** / **Stop**) للتحكم الكامل في المسبحة الآلية.
* 🎨 **تنسيق الخطوط والألوان**: تغيير ألوان العناوين وتغيير النصوص ديناميكياً.
* 🖼️ **معرض صور تفاعلي**: تغيير الصور والعناوين (Boy, Girl, Book, Pen).
* 🔗 **ربط محركات البحث**: فتح روابط البحث على Google مباشرة بنقرة زر.

---

## 📂 هيكل المشروع (Project Structure)

```text
├── Form1.cs             # الشاشة الرئيسية والتسبيح الآلي والتحكم بالألوان والترابط
├── Form1.Designer.cs    # تصميم واجهة Form1 وتوزيع الأزرار
├── Form2.cs             # منطق برنامج إدارة المهام (To-Do List)
├── Form2.Designer.cs    # تصميم واجهة قائمة المهام والعدادات الحية
├── Form3.cs             # منطق حاسبة العمر بـ DateTimePicker
├── Form3.Designer.cs    # تصميم حاسبة العمر باللون الأخضر المتناسق
├── Program.cs           # نقطة الانطلاق الرئيسية للتطبيق (Main Entry Point)
└── Properties/          # إعدادات المشروع وموارد الصور والخصائص
```

---

## 🛠️ التقنيات المستخدمة (Tech Stack)

* **لغة البرمجة**: C# (CSharp)
* **الإطار البرمجي**: .NET Framework 4.8
* **تقنية الواجهات**: Windows Forms (WinForms)
* **بيئة التطوير**: Microsoft Visual Studio 2022

---

## 🚀 كيفية التشغيل (How to Run)

1. **نسخ المستودع (Clone Repository)**:
   ```bash
   git clone https://github.com/username/WinForms-Desktop-Suite.git
   ```
2. **فتح المشروع**:
   * افتح ملف `progect after tic.sln` أو `progect after tic.csproj` بواسطة **Visual Studio**.
3. **تشغيل المشروع**:
   * اضغط على زر **Start** أو المفتاح **`F5`** لبدء التشغيل.
   * يمكنك تغيير الشاشة الابتدائية من ملف `Program.cs` باختيار `new Form1()` أو `new Form2()` أو `new Form3()`.

---

## 📝 الترخيص (License)

هذا المشروع مرخص بموجب رخصة [MIT License](LICENSE) - يمكنك استخدامه والتعديل عليه بحرية.
