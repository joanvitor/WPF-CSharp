   M S B A M L   `   `   `  ����J  FSalario Liquido, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Salario_LiquidoSalario_Liquido  5   	        Salario_Liquido.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Salario_Liquido     5   	     � Title$  Cálculo de Salário��5   	   $	��400��6$   $	��500��61   .��5	      � .+�5
   
   �� $��Nome do Funcionário��6   $
��Left=�6.   $��	20,20,0,0q�6I   $	��Top=�6\   �� 5   
   -   5         ��Name$ txtNameFunc��5      $
��Left=�6'   $��23��6B   $��	20,46,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��430��6�   �� 5   
   $��Qtde de horas trabalhadas��6   $
��Left=�64   $��	20,89,0,0q�6O   $	��Top=�6b    J� RenderTransformOrigin$ -0.327,-1.527&�6z   �� 5   
   -   5        $ txtQtde��5      $
��Left=�6#   $��23��6>   $��
20,115,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��200��6�    � ToolTip$# Informe a quantidade de horas��6�   �� 5   
   $��Valor da Hora trabalhada��6   $
��Left=�63   $��
250,89,0,0q�6N   $	��Top=�6b   $ 1.053,-1.769&�6z   �� 5   
   -   5        $ txtValor��5      $
��Left=�6$   $��23��6?   $��250,115,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��200��6�   $ Informe o valor da hora��6�   �� 5   
   $��Salário Liquido��6   $
��Left=�6*   $��
20,175,0,0q�6E   $	��Top=�6Y   �� 5   
   -   5        $ 
txtSalario��5      $
��Left=�6&   $��23��6A   $��
20,201,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   {�.  6�   �� 5   
   -   5         ��Name$ btnCalcular��5      $��Calcular��6&   $
��Left=�69   $��375,148,0,0q�6T   $	��Top=�6i   $��75��6�   $��23��6�   6�   5      5      