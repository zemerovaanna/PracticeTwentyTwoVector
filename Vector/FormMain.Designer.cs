namespace Vector
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.X = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.Z = new System.Windows.Forms.Label();
            this.NumericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.CreateVector = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.ComboBoxVectorA = new System.Windows.Forms.ComboBox();
            this.ComboBoxVectorB = new System.Windows.Forms.ComboBox();
            this.ComboBoxAction = new System.Windows.Forms.ComboBox();
            this.VectorA = new System.Windows.Forms.Label();
            this.VectorB = new System.Windows.Forms.Label();
            this.Action = new System.Windows.Forms.Label();
            this.VectorsInformation = new System.Windows.Forms.Label();
            this.InfoVectorA = new System.Windows.Forms.Label();
            this.InfoVectorB = new System.Windows.Forms.Label();
            this.InfoVectorC = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.TextBoxVectorName = new System.Windows.Forms.TextBox();
            this.TabControlActionVector = new System.Windows.Forms.TabControl();
            this.TabPageCreateSaveVector = new System.Windows.Forms.TabPage();
            this.VectorName = new System.Windows.Forms.Label();
            this.ComboBoxCreateFileName = new System.Windows.Forms.TextBox();
            this.ComboBoxCreatedFileName = new System.Windows.Forms.ComboBox();
            this.RadioButtonCreateFile = new System.Windows.Forms.RadioButton();
            this.RadioButtonCreatedFile = new System.Windows.Forms.RadioButton();
            this.ChoiceFile = new System.Windows.Forms.Label();
            this.InformationActionVector = new System.Windows.Forms.TabPage();
            this.ChoiceFileName = new System.Windows.Forms.Label();
            this.СomboBoxChoiceFileName = new System.Windows.Forms.ComboBox();
            this.ResultAction = new System.Windows.Forms.Label();
            this.LabelResultAction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownZ)).BeginInit();
            this.TabControlActionVector.SuspendLayout();
            this.TabPageCreateSaveVector.SuspendLayout();
            this.InformationActionVector.SuspendLayout();
            this.SuspendLayout();
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X.Location = new System.Drawing.Point(9, 116);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(132, 23);
            this.X.TabIndex = 1;
            this.X.Text = "Первая точка:";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y.Location = new System.Drawing.Point(9, 152);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(130, 23);
            this.Y.TabIndex = 2;
            this.Y.Text = "Вторая точка:";
            // 
            // Z
            // 
            this.Z.AutoSize = true;
            this.Z.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Z.Location = new System.Drawing.Point(9, 193);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(126, 23);
            this.Z.TabIndex = 3;
            this.Z.Text = "Третья точка:";
            // 
            // NumericUpDownX
            // 
            this.NumericUpDownX.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumericUpDownX.Location = new System.Drawing.Point(184, 109);
            this.NumericUpDownX.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NumericUpDownX.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.NumericUpDownX.Name = "NumericUpDownX";
            this.NumericUpDownX.Size = new System.Drawing.Size(254, 30);
            this.NumericUpDownX.TabIndex = 4;
            this.NumericUpDownX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericUpDownY
            // 
            this.NumericUpDownY.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumericUpDownY.Location = new System.Drawing.Point(184, 145);
            this.NumericUpDownY.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NumericUpDownY.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.NumericUpDownY.Name = "NumericUpDownY";
            this.NumericUpDownY.Size = new System.Drawing.Size(254, 30);
            this.NumericUpDownY.TabIndex = 5;
            this.NumericUpDownY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericUpDownZ
            // 
            this.NumericUpDownZ.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumericUpDownZ.Location = new System.Drawing.Point(184, 186);
            this.NumericUpDownZ.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NumericUpDownZ.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.NumericUpDownZ.Name = "NumericUpDownZ";
            this.NumericUpDownZ.Size = new System.Drawing.Size(254, 30);
            this.NumericUpDownZ.TabIndex = 6;
            this.NumericUpDownZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CreateVector
            // 
            this.CreateVector.AutoSize = true;
            this.CreateVector.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateVector.Location = new System.Drawing.Point(9, 3);
            this.CreateVector.Name = "CreateVector";
            this.CreateVector.Size = new System.Drawing.Size(150, 23);
            this.CreateVector.TabIndex = 7;
            this.CreateVector.Text = "Создать вектор:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonSave.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSave.Location = new System.Drawing.Point(9, 378);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(429, 34);
            this.ButtonSave.TabIndex = 8;
            this.ButtonSave.Text = "Сохранить в файл";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonLoad.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLoad.Location = new System.Drawing.Point(7, 70);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(502, 33);
            this.ButtonLoad.TabIndex = 9;
            this.ButtonLoad.Text = "Обновить список векторов";
            this.ButtonLoad.UseVisualStyleBackColor = false;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // ComboBoxVectorA
            // 
            this.ComboBoxVectorA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxVectorA.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxVectorA.FormattingEnabled = true;
            this.ComboBoxVectorA.Location = new System.Drawing.Point(153, 148);
            this.ComboBoxVectorA.Name = "ComboBoxVectorA";
            this.ComboBoxVectorA.Size = new System.Drawing.Size(356, 31);
            this.ComboBoxVectorA.TabIndex = 10;
            this.ComboBoxVectorA.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVectorA_SelectedIndexChanged);
            // 
            // ComboBoxVectorB
            // 
            this.ComboBoxVectorB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxVectorB.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxVectorB.FormattingEnabled = true;
            this.ComboBoxVectorB.Location = new System.Drawing.Point(153, 185);
            this.ComboBoxVectorB.Name = "ComboBoxVectorB";
            this.ComboBoxVectorB.Size = new System.Drawing.Size(356, 31);
            this.ComboBoxVectorB.TabIndex = 10;
            this.ComboBoxVectorB.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVectorB_SelectedIndexChanged);
            // 
            // ComboBoxAction
            // 
            this.ComboBoxAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAction.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxAction.FormattingEnabled = true;
            this.ComboBoxAction.Items.AddRange(new object[] {
            "Вычислить длину первого вектора",
            "Вычислить длину второго вектора",
            "Вычислить длину третьего вектора",
            "Получение третьего вектора сложением",
            "Получение третьего вектора вычитанием",
            "Скалярное произведение векторов",
            "Вычисление косинуса угла между векторами"});
            this.ComboBoxAction.Location = new System.Drawing.Point(106, 232);
            this.ComboBoxAction.Name = "ComboBoxAction";
            this.ComboBoxAction.Size = new System.Drawing.Size(403, 31);
            this.ComboBoxAction.TabIndex = 10;
            this.ComboBoxAction.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAction_SelectedIndexChanged);
            // 
            // VectorA
            // 
            this.VectorA.AutoSize = true;
            this.VectorA.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VectorA.Location = new System.Drawing.Point(3, 151);
            this.VectorA.Name = "VectorA";
            this.VectorA.Size = new System.Drawing.Size(145, 23);
            this.VectorA.TabIndex = 11;
            this.VectorA.Text = "Первый вектор:";
            // 
            // VectorB
            // 
            this.VectorB.AutoSize = true;
            this.VectorB.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VectorB.Location = new System.Drawing.Point(2, 188);
            this.VectorB.Name = "VectorB";
            this.VectorB.Size = new System.Drawing.Size(140, 23);
            this.VectorB.TabIndex = 12;
            this.VectorB.Text = "Второй вектор:";
            // 
            // Action
            // 
            this.Action.AutoSize = true;
            this.Action.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Action.Location = new System.Drawing.Point(2, 235);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(98, 23);
            this.Action.TabIndex = 13;
            this.Action.Text = "Действие:";
            // 
            // VectorsInformation
            // 
            this.VectorsInformation.AutoSize = true;
            this.VectorsInformation.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VectorsInformation.Location = new System.Drawing.Point(3, 311);
            this.VectorsInformation.Name = "VectorsInformation";
            this.VectorsInformation.Size = new System.Drawing.Size(226, 23);
            this.VectorsInformation.TabIndex = 14;
            this.VectorsInformation.Text = "Информация о векторах:";
            // 
            // InfoVectorA
            // 
            this.InfoVectorA.AutoSize = true;
            this.InfoVectorA.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoVectorA.Location = new System.Drawing.Point(3, 344);
            this.InfoVectorA.Name = "InfoVectorA";
            this.InfoVectorA.Size = new System.Drawing.Size(145, 23);
            this.InfoVectorA.TabIndex = 15;
            this.InfoVectorA.Text = "Первый вектор:";
            // 
            // InfoVectorB
            // 
            this.InfoVectorB.AutoSize = true;
            this.InfoVectorB.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoVectorB.Location = new System.Drawing.Point(3, 387);
            this.InfoVectorB.Name = "InfoVectorB";
            this.InfoVectorB.Size = new System.Drawing.Size(140, 23);
            this.InfoVectorB.TabIndex = 16;
            this.InfoVectorB.Text = "Второй вектор:";
            // 
            // InfoVectorC
            // 
            this.InfoVectorC.AutoSize = true;
            this.InfoVectorC.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoVectorC.Location = new System.Drawing.Point(3, 431);
            this.InfoVectorC.Name = "InfoVectorC";
            this.InfoVectorC.Size = new System.Drawing.Size(137, 23);
            this.InfoVectorC.TabIndex = 17;
            this.InfoVectorC.Text = "Третий вектор:";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.A.Location = new System.Drawing.Point(149, 348);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(135, 19);
            this.A.TabIndex = 18;
            this.A.Text = "выберите вектор";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.B.Location = new System.Drawing.Point(149, 391);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(135, 19);
            this.B.TabIndex = 19;
            this.B.Text = "выберите вектор";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.C.Location = new System.Drawing.Point(149, 435);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(325, 19);
            this.C.TabIndex = 20;
            this.C.Text = "выберите действие для создания вектора";
            // 
            // TextBoxVectorName
            // 
            this.TextBoxVectorName.Location = new System.Drawing.Point(184, 47);
            this.TextBoxVectorName.Name = "TextBoxVectorName";
            this.TextBoxVectorName.Size = new System.Drawing.Size(254, 30);
            this.TextBoxVectorName.TabIndex = 21;
            // 
            // TabControlActionVector
            // 
            this.TabControlActionVector.Controls.Add(this.TabPageCreateSaveVector);
            this.TabControlActionVector.Controls.Add(this.InformationActionVector);
            this.TabControlActionVector.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabControlActionVector.Location = new System.Drawing.Point(12, 12);
            this.TabControlActionVector.Name = "TabControlActionVector";
            this.TabControlActionVector.SelectedIndex = 0;
            this.TabControlActionVector.Size = new System.Drawing.Size(523, 504);
            this.TabControlActionVector.TabIndex = 22;
            // 
            // TabPageCreateSaveVector
            // 
            this.TabPageCreateSaveVector.Controls.Add(this.VectorName);
            this.TabPageCreateSaveVector.Controls.Add(this.ComboBoxCreateFileName);
            this.TabPageCreateSaveVector.Controls.Add(this.ComboBoxCreatedFileName);
            this.TabPageCreateSaveVector.Controls.Add(this.RadioButtonCreateFile);
            this.TabPageCreateSaveVector.Controls.Add(this.RadioButtonCreatedFile);
            this.TabPageCreateSaveVector.Controls.Add(this.ChoiceFile);
            this.TabPageCreateSaveVector.Controls.Add(this.TextBoxVectorName);
            this.TabPageCreateSaveVector.Controls.Add(this.X);
            this.TabPageCreateSaveVector.Controls.Add(this.Y);
            this.TabPageCreateSaveVector.Controls.Add(this.Z);
            this.TabPageCreateSaveVector.Controls.Add(this.NumericUpDownX);
            this.TabPageCreateSaveVector.Controls.Add(this.NumericUpDownY);
            this.TabPageCreateSaveVector.Controls.Add(this.NumericUpDownZ);
            this.TabPageCreateSaveVector.Controls.Add(this.CreateVector);
            this.TabPageCreateSaveVector.Controls.Add(this.ButtonSave);
            this.TabPageCreateSaveVector.Location = new System.Drawing.Point(4, 32);
            this.TabPageCreateSaveVector.Name = "TabPageCreateSaveVector";
            this.TabPageCreateSaveVector.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageCreateSaveVector.Size = new System.Drawing.Size(515, 468);
            this.TabPageCreateSaveVector.TabIndex = 0;
            this.TabPageCreateSaveVector.Text = "Создать и Сохранить вектор";
            this.TabPageCreateSaveVector.UseVisualStyleBackColor = true;
            this.TabPageCreateSaveVector.Click += new System.EventHandler(this.TabPageCreateSaveVector_Click);
            // 
            // VectorName
            // 
            this.VectorName.AutoSize = true;
            this.VectorName.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VectorName.Location = new System.Drawing.Point(9, 50);
            this.VectorName.Name = "VectorName";
            this.VectorName.Size = new System.Drawing.Size(172, 23);
            this.VectorName.TabIndex = 27;
            this.VectorName.Text = "Название вектора:";
            // 
            // ComboBoxCreateFileName
            // 
            this.ComboBoxCreateFileName.Location = new System.Drawing.Point(184, 342);
            this.ComboBoxCreateFileName.Name = "ComboBoxCreateFileName";
            this.ComboBoxCreateFileName.Size = new System.Drawing.Size(254, 30);
            this.ComboBoxCreateFileName.TabIndex = 26;
            // 
            // ComboBoxCreatedFileName
            // 
            this.ComboBoxCreatedFileName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ComboBoxCreatedFileName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCreatedFileName.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.ComboBoxCreatedFileName.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxCreatedFileName.FormattingEnabled = true;
            this.ComboBoxCreatedFileName.Location = new System.Drawing.Point(184, 305);
            this.ComboBoxCreatedFileName.Name = "ComboBoxCreatedFileName";
            this.ComboBoxCreatedFileName.Size = new System.Drawing.Size(254, 31);
            this.ComboBoxCreatedFileName.TabIndex = 25;
            // 
            // RadioButtonCreateFile
            // 
            this.RadioButtonCreateFile.AutoSize = true;
            this.RadioButtonCreateFile.Checked = true;
            this.RadioButtonCreateFile.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonCreateFile.Location = new System.Drawing.Point(13, 345);
            this.RadioButtonCreateFile.Name = "RadioButtonCreateFile";
            this.RadioButtonCreateFile.Size = new System.Drawing.Size(164, 27);
            this.RadioButtonCreateFile.TabIndex = 24;
            this.RadioButtonCreateFile.TabStop = true;
            this.RadioButtonCreateFile.Text = "Создать новый:";
            this.RadioButtonCreateFile.UseVisualStyleBackColor = true;
            // 
            // RadioButtonCreatedFile
            // 
            this.RadioButtonCreatedFile.AutoSize = true;
            this.RadioButtonCreatedFile.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonCreatedFile.Location = new System.Drawing.Point(13, 312);
            this.RadioButtonCreatedFile.Name = "RadioButtonCreatedFile";
            this.RadioButtonCreatedFile.Size = new System.Drawing.Size(145, 27);
            this.RadioButtonCreatedFile.TabIndex = 23;
            this.RadioButtonCreatedFile.Text = "В созданный:";
            this.RadioButtonCreatedFile.UseVisualStyleBackColor = true;
            // 
            // ChoiceFile
            // 
            this.ChoiceFile.AutoSize = true;
            this.ChoiceFile.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoiceFile.Location = new System.Drawing.Point(9, 283);
            this.ChoiceFile.Name = "ChoiceFile";
            this.ChoiceFile.Size = new System.Drawing.Size(131, 23);
            this.ChoiceFile.TabIndex = 22;
            this.ChoiceFile.Text = "Выбор файла:";
            // 
            // InformationActionVector
            // 
            this.InformationActionVector.Controls.Add(this.LabelResultAction);
            this.InformationActionVector.Controls.Add(this.ResultAction);
            this.InformationActionVector.Controls.Add(this.ChoiceFileName);
            this.InformationActionVector.Controls.Add(this.СomboBoxChoiceFileName);
            this.InformationActionVector.Controls.Add(this.InfoVectorA);
            this.InformationActionVector.Controls.Add(this.ButtonLoad);
            this.InformationActionVector.Controls.Add(this.C);
            this.InformationActionVector.Controls.Add(this.ComboBoxVectorA);
            this.InformationActionVector.Controls.Add(this.ComboBoxVectorB);
            this.InformationActionVector.Controls.Add(this.VectorsInformation);
            this.InformationActionVector.Controls.Add(this.InfoVectorC);
            this.InformationActionVector.Controls.Add(this.ComboBoxAction);
            this.InformationActionVector.Controls.Add(this.B);
            this.InformationActionVector.Controls.Add(this.VectorA);
            this.InformationActionVector.Controls.Add(this.A);
            this.InformationActionVector.Controls.Add(this.VectorB);
            this.InformationActionVector.Controls.Add(this.InfoVectorB);
            this.InformationActionVector.Controls.Add(this.Action);
            this.InformationActionVector.Location = new System.Drawing.Point(4, 32);
            this.InformationActionVector.Name = "InformationActionVector";
            this.InformationActionVector.Padding = new System.Windows.Forms.Padding(3);
            this.InformationActionVector.Size = new System.Drawing.Size(515, 468);
            this.InformationActionVector.TabIndex = 1;
            this.InformationActionVector.Text = "Информация и Действия";
            this.InformationActionVector.UseVisualStyleBackColor = true;
            this.InformationActionVector.Click += new System.EventHandler(this.InformationActionVector_Click);
            // 
            // ChoiceFileName
            // 
            this.ChoiceFileName.AutoSize = true;
            this.ChoiceFileName.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoiceFileName.Location = new System.Drawing.Point(191, 7);
            this.ChoiceFileName.Name = "ChoiceFileName";
            this.ChoiceFileName.Size = new System.Drawing.Size(131, 23);
            this.ChoiceFileName.TabIndex = 22;
            this.ChoiceFileName.Text = "Выбор файла:";
            // 
            // СomboBoxChoiceFileName
            // 
            this.СomboBoxChoiceFileName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.СomboBoxChoiceFileName.FormattingEnabled = true;
            this.СomboBoxChoiceFileName.Location = new System.Drawing.Point(7, 33);
            this.СomboBoxChoiceFileName.Name = "СomboBoxChoiceFileName";
            this.СomboBoxChoiceFileName.Size = new System.Drawing.Size(502, 31);
            this.СomboBoxChoiceFileName.TabIndex = 21;
            // 
            // ResultAction
            // 
            this.ResultAction.AutoSize = true;
            this.ResultAction.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultAction.Location = new System.Drawing.Point(3, 277);
            this.ResultAction.Name = "ResultAction";
            this.ResultAction.Size = new System.Drawing.Size(189, 23);
            this.ResultAction.TabIndex = 23;
            this.ResultAction.Text = "Результат действия:";
            // 
            // LabelResultAction
            // 
            this.LabelResultAction.AutoSize = true;
            this.LabelResultAction.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.LabelResultAction.Location = new System.Drawing.Point(191, 281);
            this.LabelResultAction.Name = "LabelResultAction";
            this.LabelResultAction.Size = new System.Drawing.Size(170, 19);
            this.LabelResultAction.TabIndex = 24;
            this.LabelResultAction.Text = "действие не выбрано";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(554, 528);
            this.Controls.Add(this.TabControlActionVector);
            this.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Векторы";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownZ)).EndInit();
            this.TabControlActionVector.ResumeLayout(false);
            this.TabPageCreateSaveVector.ResumeLayout(false);
            this.TabPageCreateSaveVector.PerformLayout();
            this.InformationActionVector.ResumeLayout(false);
            this.InformationActionVector.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label Z;
        private System.Windows.Forms.NumericUpDown NumericUpDownX;
        private System.Windows.Forms.NumericUpDown NumericUpDownY;
        private System.Windows.Forms.NumericUpDown NumericUpDownZ;
        private System.Windows.Forms.Label CreateVector;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.ComboBox ComboBoxVectorA;
        private System.Windows.Forms.ComboBox ComboBoxVectorB;
        private System.Windows.Forms.ComboBox ComboBoxAction;
        private System.Windows.Forms.Label VectorA;
        private System.Windows.Forms.Label VectorB;
        private System.Windows.Forms.Label Action;
        private System.Windows.Forms.Label VectorsInformation;
        private System.Windows.Forms.Label InfoVectorA;
        private System.Windows.Forms.Label InfoVectorB;
        private System.Windows.Forms.Label InfoVectorC;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.TextBox TextBoxVectorName;
        private System.Windows.Forms.TabControl TabControlActionVector;
        private System.Windows.Forms.TabPage TabPageCreateSaveVector;
        private System.Windows.Forms.TabPage InformationActionVector;
        private System.Windows.Forms.Label ChoiceFileName;
        private System.Windows.Forms.ComboBox СomboBoxChoiceFileName;
        private System.Windows.Forms.TextBox ComboBoxCreateFileName;
        private System.Windows.Forms.ComboBox ComboBoxCreatedFileName;
        private System.Windows.Forms.RadioButton RadioButtonCreateFile;
        private System.Windows.Forms.RadioButton RadioButtonCreatedFile;
        private System.Windows.Forms.Label ChoiceFile;
        private System.Windows.Forms.Label VectorName;
        private System.Windows.Forms.Label ResultAction;
        private System.Windows.Forms.Label LabelResultAction;
    }
}

