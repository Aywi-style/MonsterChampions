# Monster Champions
![Game icon](https://github.com/Aywi-style/MonsterChampions/raw/main/Media/icon.png)

*Карточная дуэль с механиками мёрджа в сеттинге соревнований Мастеров Покемонов.*  
[GooglePlay](https://play.google.com/store/apps/details?id=com.ZakiGames.MonsterChampions "Monster Champions page")

Я работал над игровым балансом, искусственным интеллектом как оппонентов, так и юнитов.  
Писал боевые системы, а также работал с Particle Systems. Все эффекты в игре были проработаны мной.  
Впервые написал туториал для игры, интересную работу камеры, а также впервые написал и воспользовался системой пулов.  
Также занимался креативами по проекту.  

Мною реализованы механики:
• Различных стихийных элементов и их взаимодействия между собой. Была выведена таблица поведения юнита в зависимости от его стихии и стихии вражеского юнита;  
• Работа по включению и отключению спавнера во вражеском замке, а также логика его отработки в зависимости от задач в левелдизайне;  
• Механики урона в ближнем и дальнем боях на основе стихийных бонусов;  
• Урон по замкам и их внешний отклик на это (анимация получения урона);  
• Уничтожение юнитов;  
• Система дропа объектов с юнитов при их смерти;  
• Передвижение юнитов по строгому маршруту от замка до замка;  
• Зоны обнаружения вражеского юнита в пределах видимости монстра;  
• Таргетирование юнитов и отслеживание передвижения цели;  
• Автоматическая очистка таргетирования при уничтожении цели;  
• Прокачка юнитов при их мёрдже;  
• Специфические боевые особенности юнитов:  
•• Для летающего юнита птицы - взрыв и АОЕ урон по врагам в пределах дальности способности и самой птице.  
•• Для летающего юнита стрекозы - выстрел проджектайлом (молнией) и последующий АОЕ урон от ЦЕЛИ проджектайле без урона по союзникам и самой стрекозы.  
•• Для юнита "морского конька" - накидывание дополнительного слоя защиты своим союзникам с периодичной перезарядкой. Эффект не стакается, он имеет свою стихию (воды), которая может быть отличной от стихии носителя защиты, а также имеет свой максимальный показатель в зависимости от характеристик "морского конька". Также к механике прикручен щилдгейт - впитывание всего избыточного урона в щит, без урона по здоровью носителя.  
•• Для юнита жука - накидывание дебафа на врагов, который режет их здоровье.  

Забавный момент связанный с работой камеры.  
Мы хотели реализовать интерфейс для игрока непосредственно в игровом мире, но не хватало места. Из-за этого я придумал механику благодаря которой интерактивная платформа с юнитами меняла свою форму в зависимости от положения камеры.

![Game poster](https://github.com/Aywi-style/MonsterChampions/raw/main/Media/img_1.png)
![Gameplay_1](https://github.com/Aywi-style/MonsterChampions/raw/main/Media/img_2.png)
![Gameplay_2](https://github.com/Aywi-style/MonsterChampions/raw/main/Media/img_3.png)
![Gameplay_3](https://github.com/Aywi-style/MonsterChampions/raw/main/Media/img_4.png)
![Gameplay_4](https://github.com/Aywi-style/MonsterChampions/raw/main/Media/img_5.png)
![Gameplay_5](https://github.com/Aywi-style/MonsterChampions/raw/main/Media/img_6.png)
![Gameplay_6](https://github.com/Aywi-style/MonsterChampions/raw/main/Media/img_7.png)
![Gameplay_7](https://github.com/Aywi-style/MonsterChampions/raw/main/Media/img_8.png)
