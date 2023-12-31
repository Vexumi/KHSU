﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Parser.Model
{
    public class Experiment : BaseModel
    {
        public string Name { get; set; } // Название файла
        public int CountChannels { get; set; } // Количество используемых каналов
        [NotMapped]
        public List<int> ChannelsNumber { get; set; } = new(); // Номера каналов
        [NotMapped]
        public List<int> Coupling { get; set; } = new(); // Тип связи AC или DC
        public bool AnlTrigMode { get; set; } // Флаг, показывающий включение|отключение  аналогового триггера 0-вкл. 1-выкл.
        public int AntTrigChannel { get; set; } // Номер триггерного канала
        public double LevelAnlTrig { get; set; } // Уровень напряжения (в мВ) для запуска аналогового триггера
        public int AnlTrigSlope { get; set; } // TYPE? Фронт запуска триггера
        public double ScanRate { get; set; } // Частота дискретизации (вещественная)
        public bool DigTrigMode { get; set; } // Флаг, показывающий включение цифрового триггера
        public int DigTrigEdge { get; set; } // TYPE? Фронт запуска цифрового триггера
        public int CountFramesDev { get; set; } // Количество кадров
        public int PreTrigScan { get; set; } // Количество претриггерных отсчетов в кадре на канал
        public int PostTrigScan { get; set; } // Количество послетриггерных отсчетов в кадре на канал
        public double PostTrigDelaySus { get; set; } // Время задержки (в мс) для триггера (вещественная)
        public int FrameToDraw { get; set; } // TYPE? Бесполезный параметр для графики
        public int CountGraph { get; set; } // Количество графиков на экране
        [NotMapped]
        public List<List<int>> Graph { get; set; } = new(); // Бесполезный параметр
        [NotMapped]
        public List<int> FramesToRecordDev { get; set; } = new(); // Номер кадра; если кадр записан, то равен номеру кадра, если не записан, то 0;
        [NotMapped]
        public List<double> TimeBuff { get; set; } = new(); // Время начала каждого записанного кадра (вещественные)
        [NotMapped]
        public List<List<double>> Data { get; set; } = new(); // Значения напряжений по каналам и все это столько раз, сколько кадров записано

        public int CountReading => PreTrigScan + PostTrigScan; // Количество отсчетов в кадре;
        public int CountFrames => CountFramesDev - FramesToRecordDev.Where(x => x == 0).Count(); // Количество записанных кадров 

        public int PosFramesEnd => 39 + CountFrames;
        public int PosTimesEnd => PosFramesEnd + CountFrames;
        public int PosDataEnd => PosTimesEnd + 1;
    }
}