   M S B A M L   `   `   `  ����B  >HomeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:HomeAppHomeApp  5   	       HomeApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:HomeApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   ���	#FF212121 � WindowStartupLocation$ CenterScreen=�6L   .��5	      � -   5         �Name$ SettingsWheel��5	      $	��400��6"   $��	0,10,-8,9q�6/   .+�5
   
   �� -   5         ��Name$ label��5
      $��HomeApp��6   $��208,40,196,0q�61   $	��Top=�6G   $��94��6_   $��Georgia)�6k   $��72(�6�   $
��Bold"�6�   ���	#00000000���	#FFE68A00 J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5   
   -   5         ��Name$ StartButton��5      $��316,180,316,52q�6%   $��Img/house.png��6=   $
��Fill=�6T   $	��168��6c   $	��168��6o    5        5      5      �� 5   
   -   5        $ SettingsBtn��5      $��735,10,25,350q�6%   $��Img/Settings.png��6<   $
��Fill=�6V   $��40��6e   $��40��6p    5        5         
BlurRadius$ 2Q�6#      ShadowDepth$ 3Q�62   5      �� 5   
   -   5        $ CreatorLabel��5      $��By:ÄlexDesigns��6&   $
��Left=�6?   $��28��6Z   $��665,362,0,0q�6f   $	��Top=�6{   $	��110��6�   $��Georgia)�6�   ���	#FFE68A00$��14(�6�   �� 5   
   -   5        $ 
LicenceBtn��5      $��10,360,760,10q�6$   $��Img/Licence.png��6;   $
��Fill=�6T   $��30��6c   $��30��6n   6z   �� 5   
   -   5        $ 	usrLabel1��5      $��
��6#   $
��Left=�68   $��208,208,0,0q�6S   $	��Top=�6h   $��80��6�   $��21��6�   �� 5   
   -   5        $ SettingsBtn_Copy��5      $��694,6,65,354q�6*   $��Img/user.png��6@   $
��Fill=�6V   $��40��6e    5        5      $ 2Q�6#   $ 3Q�62   5       �� 5!   
   -	   5        $ image��5!      $
��Left=�6   $	��114��6:   $��	19,20,0,0q�6G   $	��Top=�6Z   $	��156��6r   $.��(Img/nti-logo-arrow-transparent-white.png��6~   6�   5"      5#      