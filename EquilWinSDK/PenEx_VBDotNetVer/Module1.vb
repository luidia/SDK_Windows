Imports System.Runtime.InteropServices

Module Module1
    Enum PenStatus
        PEN_DOWN = 1
        PEN_MOVE
        PEN_UP
        PEN_HOVER
    End Enum

    Enum PenCalibrationStatus
        CAL_TOP = 0
        CAL_BOTTOM
        CAL_END
    End Enum

    Public Enum StationPosition
        TOP = 1
        LEFT
        RIGHT
        BOTTOM
    End Enum

    Public Enum MakerState
        RED = 81
        GREEN = 82
        YELLOW = 83
        BLUE = 84
        PEN_UP = 15
        PURPLE = 86
        BLACK = 88
        ERASER_CAP = 89
        LOW_BATTERY = 90
        BIG_ERASER = 92
    End Enum

    Enum PENSTYLE
        PENSTYLE_NORMAL = 0
        PENSTYLE_BRUSH
        PENSTYLE_HIGHLIGHT
    End Enum

    Enum GestureMessage
        GESTURE_RIGHT_LEFT = 100
        GESTURE_LEFT_RIGHT
        GESTURE_UP_DOWN
        GESTURE_DOWN_UP
        GESTURE_CIRCLE_CLOCKWISE
        GESTURE_DOUBLECIRCLE_CLOCKWISE
        GESTURE_CIRCLE_COUNTERCLOCKWISE
        GESTURE_CROSS_DOWN
        GESTURE_CROSS_UP
        GESTURE_CROSS_LEFT
        GESTURE_CROSS_RIGHT
        GESTURE_ZIGZAG
        GESTURE_CLICK
        GESTURE_DOUBLECLICK
        GESTURE_TRIPPLECLICK
        GESTURE_LONGCLICK
        GESTURE_DOUBLECROSS_DOWN
        GESTURE_DOUBLECROSS_UP
        GESTURE_DOUBLECROSS_LEFT
        GESTURE_DOUBLECROSS_RIGHT
        GESTURE_DOUBLECIRCLE_COUNTERCLOCKWISE
    End Enum

    Public Const WM_RETURNMESSAGE As Integer = &H400 + 1        'pen message
    Public Const WM_GESTUREMESSAGE As Integer = &H400 + 2       'gesture message
    Public Const WM_PENCONDITION As Integer = &H400 + 3         'gesture message
    Public Const WM_ERASER_ON As Integer = &H400 + 4

    Public Const WM_SHOWLIST As Integer = &H400 + 5             'di show list
    Public Const WM_DI_START As Integer = &H400 + 6             'di start
    Public Const WM_DI_OK As Integer = &H400 + 7                'di ok
    Public Const WM_DI_FAIL As Integer = &H400 + 8              'di fail
    Public Const WM_DI_REMOVEOK As Integer = &H400 + 9          'di remove ok
    Public Const WM_DI_ACC As Integer = &H400 + 10              'di acc
    Public Const WM_DISCONNECTPEN As Integer = &H400 + 11       'Disconnect pen
    Public Const WM_DOWNLOAD_COMPLEATE As Integer = &H400 + 12  'di download complete
    Public Const WM_DI_NEWPAGE As Integer = &H400 + 13          'New Page
    Public Const WM_DI_PAGE_NUM As Integer = &H400 + 14        'di duplicate
    Public Const WM_DI_CHANGE_STATION As Integer = &H400 + 15        'di duplicate
    Public Const WM_DISCONNECTUSB As Integer = &H400 + 16        'Disconnect Usb
    Public Const WM_DI_DUPLICATE As Integer = &H400 + 17        'Duplicate Button event
    Public Const WM_MCU_VERSION As Integer = &H400 + 18        'Duplicate Button event
    Public Const WM_TIMERRESET As Integer = &H400 + 19        'Duplicate Button event
    Public Const WM_LOST_PEN As Integer = &H400 + 20        'Disconnect by timer cannot receive pendata during 30sec


    '' Structure for receiving pen data 
    Friend Structure _pen_rec
        Public X As Integer ' X (before calibration)
        Public Y As Integer ' Y (before calibration)
        Public T As Short ' temperature (celcious)
        Public P As Integer ' pressure ( 0 ~ 900 )
        Public TX As Single '  X (after calibration)
        Public TY As Single ' Y (after calibration)
        Public FUNC As Integer 'pen button clicked
        Public ModelCode As Integer 'Device Model Code 2: Equil Smart Pen 3:Equil Smart Pen 2 4:Equil Smart Marker   
        Public Sensor_dis As Integer 'distance between sensors (need not to know) 
        Public HWVer As Integer 'HWVer 
        Public MCU1 As Integer 'MCU1 (need not to know) 
        Public MCU2 As Integer 'MCU2 (need not to know)
        Public PenStatus As Integer 'Pen tip (1: Down 2:Move 3:Up 4:Hover)
        Public IRGAP As Integer 'sensor property (need not to know) 
        'SmartMaker Variable Add
        Public PenTiming As Integer 'Maker State Data
        Public bRight As Integer
        Public Station_Position As Integer
        Public drawRectX As Integer
        Public drawRectY As Integer
    End Structure
    Public Structure PENConditionData
        Public modelCode As Integer
        Public pen_alive As Integer 'Pen alive
        Public battery_station As Integer
        Public battery_pen As Integer
        Public StationPosition As Integer
        Public usbConnect As Integer
    End Structure
    '    Public Declare Function FindPort Lib "PNFPenLib.dll" () As Boolean 'scan port from device
    Public Declare Sub OnDisconnect Lib "PNFPenLib.dll" (Terminate As Integer)
    Public Declare Function FindDevice Lib "PNFPenLib.dll" () As Boolean   'Search for USB connection
    Public Declare Sub PortSearch Lib "PNFPenLib.dll" ()
    Public Declare Sub SetReciveHandle Lib "PNFPenLib.dll" (ByVal hWnd As System.IntPtr)
    Public Declare Sub SetDrawRect Lib "PNFPenLib.dll" (ByVal Width As Double, ByVal Height As Double)
    Public Declare Sub SetDrawHandle Lib "PNFPenLib.dll" (ByVal hWnd As System.IntPtr)
    Public Declare Function CheckConnect Lib "PNFPenLib.dll" () As Boolean
    Public Declare Sub SetCalibMode Lib "PNFPenLib.dll" (ByVal bCalibMode As Boolean)
    Public Declare Sub SetPenDownThreshold Lib "PNFPenLib.dll" (ByVal iDown As Integer)
    Public Declare Sub SetCalibration_Top Lib "PNFPenLib.dll" (ByVal x As Double, ByVal y As Double)
    Public Declare Sub SetCalibration_Bottom Lib "PNFPenLib.dll" (ByVal x As Double, ByVal y As Double)
    Public Declare Sub SetCalibration_End Lib "PNFPenLib.dll" ()
    'for calibration by form
    Public Declare Sub SetCalibration_EndWithDest Lib "PNFPenLib.dll" (tx As Integer, ty As Integer, bx As Integer, by As Integer)

    Public Declare Sub SetAudio Lib "PNFPenLib.dll" (ByVal _AudioMode As Byte, ByVal _AudioVolume As Byte)
    Public Declare Function GetAudioMode Lib "PNFPenLib.dll" () As Byte
    Public Declare Function GetAudioVolume Lib "PNFPenLib.dll" () As Byte

    Public EquilModelCode As Integer = 2
End Module
