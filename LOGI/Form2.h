#pragma once

namespace LOGI {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace std;

	public ref class Form2 : public System::Windows::Forms::Form
	{
		public:
			Form2(void)
			{
				InitializeComponent();
			}

		protected:
			~Form2()
			{
				if (components)
				{
					delete components;
				}
			}
	private: System::Windows::Forms::Label^ label1;
	protected:
	private:

		private: 

		private: 

		private: 

		private:
			System::ComponentModel::Container ^components;

	#pragma region Windows Form Designer generated code
		void InitializeComponent(void)
		{
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Segoe UI", 9, System::Drawing::FontStyle::Bold));
			this->label1->Location = System::Drawing::Point(29, 13);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(102, 15);
			this->label1->TabIndex = 0;
			this->label1->Text = L"ArmA3 Directory";
			// 
			// Form2
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(7, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(674, 303);
			this->Controls->Add(this->label1);
			this->Font = (gcnew System::Drawing::Font(L"Segoe UI", 8.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->Name = L"Form2";
			this->Text = L"LOGI Launcher";
			this->Load += gcnew System::EventHandler(this, &Form2::Form2_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
	#pragma endregion
		private: 


		System::Void Form2_Load(System::Object^ sender, System::EventArgs^ e) 
		{
			// Need to find arma3 dir
			// Registry: Computer\HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Bohemia Interactive\arma 3
		}

		System::Void Form2_FormClosing(System::Object^ sender, System::EventArgs^ e)
		{
			this->Hide();
		}
	};
}
