#pragma once

namespace LOGI {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
		}

	protected:

		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::ProgressBar^ pbBar;
	protected:
	private: System::Windows::Forms::Button^ bCheck;
	private: System::Windows::Forms::ComboBox^ cbRepo;
	private: System::Windows::Forms::Button^ bSettings;

	private:
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(Form1::typeid));
			this->pbBar = (gcnew System::Windows::Forms::ProgressBar());
			this->bCheck = (gcnew System::Windows::Forms::Button());
			this->cbRepo = (gcnew System::Windows::Forms::ComboBox());
			this->bSettings = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// pbBar
			// 
			this->pbBar->Location = System::Drawing::Point(11, 501);
			this->pbBar->Name = L"pbBar";
			this->pbBar->Size = System::Drawing::Size(689, 28);
			this->pbBar->TabIndex = 0;
			// 
			// bCheck
			// 
			this->bCheck->Font = (gcnew System::Drawing::Font(L"Segoe UI", 9, System::Drawing::FontStyle::Bold));
			this->bCheck->Location = System::Drawing::Point(798, 480);
			this->bCheck->Name = L"bCheck";
			this->bCheck->Size = System::Drawing::Size(131, 51);
			this->bCheck->TabIndex = 1;
			this->bCheck->Text = L"CHECK MODS";
			this->bCheck->UseVisualStyleBackColor = true;
			this->bCheck->Click += gcnew System::EventHandler(this, &Form1::bCheck_Click);
			// 
			// cbRepo
			// 
			this->cbRepo->Font = (gcnew System::Drawing::Font(L"Segoe UI", 9));
			this->cbRepo->FormattingEnabled = true;
			this->cbRepo->Items->AddRange(gcnew cli::array< System::Object^  >(1) { L"Session Repo" });
			this->cbRepo->Location = System::Drawing::Point(798, 453);
			this->cbRepo->Name = L"cbRepo";
			this->cbRepo->Size = System::Drawing::Size(131, 23);
			this->cbRepo->TabIndex = 2;
			// 
			// bSettings
			// 
			this->bSettings->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"bSettings.Image")));
			this->bSettings->Location = System::Drawing::Point(751, 480);
			this->bSettings->Name = L"bSettings";
			this->bSettings->Size = System::Drawing::Size(41, 51);
			this->bSettings->TabIndex = 3;
			this->bSettings->UseVisualStyleBackColor = true;
			this->bSettings->Click += gcnew System::EventHandler(this, &Form1::bSettings_Click);
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(941, 543);
			this->Controls->Add(this->bSettings);
			this->Controls->Add(this->cbRepo);
			this->Controls->Add(this->bCheck);
			this->Controls->Add(this->pbBar);
			this->Font = (gcnew System::Drawing::Font(L"Segoe UI", 8.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"Form1";
			this->Text = L"LOGI Launcher";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			this->ResumeLayout(false);

		}
#pragma endregion
	private: 
	System::Void Form1_Load(System::Object^ sender, System::EventArgs^ e) 
	{
		bCheck->Text = "CHECK MODS";			//Make sure 'check' is first
		cbRepo->SelectedItem = "Session Repo";	//default repo

		// Create the settings form and hide it until called

	}
	private: System::Void bCheck_Click(System::Object^ sender, System::EventArgs^ e) 
	{

	}
	private: System::Void bSettings_Click(System::Object^ sender, System::EventArgs^ e) 
	{
		
	}
};
}
