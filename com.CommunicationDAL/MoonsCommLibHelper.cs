using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;

namespace com.CommunicationDAL
{
  public  class MoonsCommLibHelper
    {
        #region public fields
        public int COMMSTATUS_OK = 0x00; // OK
        public int COMMSTATUS_TIMEOUT = 0x01; // Command time out				?1
        public int COMMSTATUS_PARAMETERISTOOLONG = 0x02; // Parameter is too long			?2
        public int COMMSTATUS_TOOFEWPARAMETERS = 0x03; // Too few parameters				?3
        public int COMMSTATUS_TOOMANYPARAMETERS = 0x04; // Too many parameters			?4
        public int COMMSTATUS_PARAMETEROUTOFRANGE = 0x05; // Parameter out of range			?5
        public int COMMSTATUS_CommandBufferFull = 0x06; // Command buffer full			?6
        public int COMMSTATUS_CANNOTPROCESSCOMMAND = 0x07; // Cannot process command			?7
        public int COMMSTATUS_PROGRAMRUNNING = 0x08; // Program running				?8
        public int COMMSTATUS_BADPASSWORD = 0x09; // Bad password					?9
        public int COMMSTATUS_COMMPORTERROR = 0x0A; // Comm port error				?10
        public int COMMSTATUS_BADCHARACTER = 0x0B; // Bad character					?11
        public int COMMSTATUS_IOALREADYUSED = 0x0C; // IO already used				?12
        public int COMMSTATUS_INCORRECTIOCONFIGURATION = 0x0D;  // Incorrect IO Configuration		?13
        public int COMMSTATUS_INCORRECTIOFUNCTION = 0x0D; // Incorrect IO function			?14
        public int COMMSTATUS_OPENPORTFAILED = 0x64; // Fail to OpenPort
        public int COMMSTATUS_PORTISNOTOPEN = 0x65;// Serial Port is not open
        public int COMMSTATUS_NORESPONSE = 0x66;// Drive did not response
        public int COMMSTATUS_INCORRECTRESPONSE = 0x67; // Drive's response is incorrect
        public int COMMSTATUS_CHECKSUMERROR = 0x68;  // CheckSumError
        #endregion

        #region Private Methods

        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "IsOpen", CharSet = CharSet.Auto)]
        private static extern bool _IsOpen();

        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "OpenPort", CharSet = CharSet.Auto)]
        private static extern int _OpenPort(int port, int baudRate, byte protocol, bool hexFormat);

        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ClosePort", CharSet = CharSet.Auto)]
        private static extern int _ClosePort();

        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "SendCommand", CharSet = CharSet.Auto)]
        private static extern int _SendCommand(byte[] command, char rs485Address = (char)0);

        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ExecuteCommand", CharSet = CharSet.Auto)]
        private static extern string _ExecuteCommand(byte[] command, char rs485Address = (char)0, int timeOut = 50);

        // AC
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadAccelerationRate", CharSet = CharSet.Auto)]
        private static extern int _ReadAccelerationRate(ref double accel, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteAccelerationRate", CharSet = CharSet.Auto)]
        private static extern int _WriteAccelerationRate(double accel, char rs485Address = (char)0, int timeOut = 50);

        // AD
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadAnalogDeadband", CharSet = CharSet.Auto)]
        private static extern int _ReadAnalogDeadband(ref byte analogDeadband, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteAnalogDeadband", CharSet = CharSet.Auto)]
        private static extern int _WriteAnalogDeadband(byte analogDeadband, char rs485Address = (char)0, int timeOut = 50);
        // AF
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadAnalogFilter", CharSet = CharSet.Auto)]
        private static extern int _ReadAnalogFilter(ref int analogFilter, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteAnalogFilter", CharSet = CharSet.Auto)]
        private static extern int _WriteAnalogFilter(int analogFilter, char rs485Address = (char)0, int timeOut = 50);
        // AG
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadAnalogVelocityGain", CharSet = CharSet.Auto)]
        private static extern int _ReadAnalogVelocityGain(ref int analogVelocityGain, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteAnalogVelocityGain", CharSet = CharSet.Auto)]
        private static extern int _WriteAnalogVelocityGain(int analogVelocityGain, char rs485Address = (char)0, int timeOut = 50);
        // AI
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadAlarmResetInput", CharSet = CharSet.Auto)]
        private static extern int _ReadAlarmResetInput(ref byte alarmResetInput, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteAlarmResetInput", CharSet = CharSet.Auto)]
        private static extern int _WriteAlarmResetInput(byte alarmResetInput, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadAlarmResetInputFlexIO", CharSet = CharSet.Auto)]
        private static extern int _ReadAlarmResetInputFlexIO(byte input, ref byte alarmResetInput, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteAlarmResetInputFlexIO", CharSet = CharSet.Auto)]
        private static extern int _WriteAlarmResetInputFlexIO(byte input, byte alarmResetInput, char rs485Address = (char)0, int timeOut = 50);
        // AL
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadAlarmCode", CharSet = CharSet.Auto)]
        private static extern int _ReadAlarmCode(ref int alarmCode, char rs485Address = (char)0, int timeOut = 50);
        // AM
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadMaxAcceleration", CharSet = CharSet.Auto)]
        private static extern int _ReadMaxAcceleration(ref double maxAcceleration, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteMaxAcceleration", CharSet = CharSet.Auto)]
        private static extern int _WriteMaxAcceleration(double maxAcceleration, char rs485Address = (char)0, int timeOut = 50);
        // AN
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadAnalogTorqueGain", CharSet = CharSet.Auto)]
        private static extern int _ReadAnalogTorqueGain(ref double analogTorqueGain, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteAnalogTorqueGain", CharSet = CharSet.Auto)]
        private static extern int _WriteAnalogTorqueGain(double analogTorqueGain, char rs485Address = (char)0, int timeOut = 50);
        // AO
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadAlarmOutput", CharSet = CharSet.Auto)]
        private static extern int _ReadAlarmOutput(ref byte alarmOutput, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteAlarmOutput", CharSet = CharSet.Auto)]
        private static extern int _WriteAlarmOutput(byte alarmOutput, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadAlarmOutputFlexIO", CharSet = CharSet.Auto)]
        private static extern int _ReadAlarmOutputFlexIO(byte output, ref byte alarmOutput, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteAlarmOutputFlexIO", CharSet = CharSet.Auto)]
        private static extern int _WriteAlarmOutputFlexIO(byte output, byte alarmOutput, char rs485Address = (char)0, int timeOut = 50);
        // AP
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadAnalogPositionGain", CharSet = CharSet.Auto)]
        private static extern int _ReadAnalogPositionGain(ref int positionGain, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteAnalogPositionGain", CharSet = CharSet.Auto)]
        private static extern int _WriteAnalogPositionGain(int positionGain, char rs485Address = (char)0, int timeOut = 50);
        // AR
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteAlarmReset", CharSet = CharSet.Auto)]
        private static extern int _WriteAlarmReset(bool immediate, char rs485Address = (char)0, int timeOut = 50);
        // AS
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadAnalogScaling", CharSet = CharSet.Auto)]
        private static extern int _ReadAnalogScaling(ref byte scaling, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteAnalogScaling", CharSet = CharSet.Auto)]
        private static extern int _WriteAnalogScaling(byte scaling, char rs485Address = (char)0, int timeOut = 50);
        // AT
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadAnalogThreshold", CharSet = CharSet.Auto)]
        private static extern int _ReadAnalogThreshold(ref double analogThreshold, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteAnalogThreshold", CharSet = CharSet.Auto)]
        private static extern int _WriteAnalogThreshold(double analogThreshold, char rs485Address = (char)0, int timeOut = 50);
        // AV
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadAnalogOffset", CharSet = CharSet.Auto)]
        private static extern int _ReadAnalogOffset(ref double analogOffset, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteAnalogOffset", CharSet = CharSet.Auto)]
        private static extern int _WriteAnalogOffset(double analogOffset, char rs485Address = (char)0, int timeOut = 50);
        // AZ
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteAnalogZero", CharSet = CharSet.Auto)]
        private static extern int _WriteAnalogZero(char rs485Address = (char)0, int timeOut = 50);
        // BD
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadBrakeDisengageDelay", CharSet = CharSet.Auto)]
        private static extern int _ReadBrakeDisengageDelay(ref double brakeDisengageDelay, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteBrakeDisengageDelay", CharSet = CharSet.Auto)]
        private static extern int _WriteBrakeDisengageDelay(double brakeDisengageDelay, char rs485Address = (char)0, int timeOut = 50);
        // BE
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadBrakeEngageDelay", CharSet = CharSet.Auto)]
        private static extern int _ReadBrakeEngageDelay(ref double brakeEngageDelay, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteBrakeEngageDelay", CharSet = CharSet.Auto)]
        private static extern int _WriteBrakeEngageDelay(double brakeEngageDelay, char rs485Address = (char)0, int timeOut = 50);
        // BO
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadBrakeOutput", CharSet = CharSet.Auto)]
        private static extern int _ReadBrakeOutput(ref byte brakeOutput, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteBrakeOutput", CharSet = CharSet.Auto)]
        private static extern int _WriteBrakeOutput(byte brakeOutput, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadBrakeOutputFlexIO", CharSet = CharSet.Auto)]
        private static extern int _ReadBrakeOutputFlexIO(byte output, ref byte brakeOutput, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteBrakeOutputFlexIO", CharSet = CharSet.Auto)]
        private static extern int _WriteBrakeOutputFlexIO(byte output, byte brakeOutput, char rs485Address = (char)0, int timeOut = 50);
        // BR
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadBaudRate", CharSet = CharSet.Auto)]
        private static extern int _ReadBaudRate(ref byte baudRate, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteBaudRate", CharSet = CharSet.Auto)]
        private static extern int _WriteBaudRate(byte baudRate, char rs485Address = (char)0, int nTimeOut = 200);
        // BS
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadBufferStatus", CharSet = CharSet.Auto)]
        private static extern int _ReadBufferStatus(ref byte bufferStatus, char rs485Address = (char)0, int timeOut = 50);
        // CA
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadChangeAccelerationCurrent", CharSet = CharSet.Auto)]
        private static extern int _ReadChangeAccelerationCurrent(ref double changeAccelerationCurrent, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteChangeAccelerationCurrent", CharSet = CharSet.Auto)]
        private static extern int _WriteChangeAccelerationCurrent(double changeAccelerationCurrent, char rs485Address = (char)0, int timeOut = 50);
        // CC
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadChangeCurrent", CharSet = CharSet.Auto)]
        private static extern int _ReadChangeCurrent(ref double changeCurrent, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteChangeCurrent", CharSet = CharSet.Auto)]
        private static extern int _WriteChangeCurrent(double changeCurrent, char rs485Address = (char)0, int timeOut = 50);
        // CD
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadIdleCurrentDelayTime", CharSet = CharSet.Auto)]
        private static extern int _ReadIdleCurrentDelayTime(ref double idleCurrentDelayTime, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteIdleCurrentDelayTime", CharSet = CharSet.Auto)]
        private static extern int _WriteIdleCurrentDelayTime(double idleCurrentDelayTime, char rs485Address = (char)0, int timeOut = 50);
        // CE
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadCommunicationError", CharSet = CharSet.Auto)]
        private static extern int _ReadCommunicationError(ref int communicationError, char rs485Address = (char)0, int timeOut = 50);
        // CF
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadAnalogAntiResonanceFilterFreq", CharSet = CharSet.Auto)]
        private static extern int _ReadAnalogAntiResonanceFilterFreq(ref int antiResonanceFilterFreq, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteAnalogAntiResonanceFilterFreq", CharSet = CharSet.Auto)]
        private static extern int _WriteAnalogAntiResonanceFilterFreq(int antiResonanceFilterFreq, char rs485Address = (char)0, int timeOut = 50);
        // CG
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadAnalogAntiResonanceFilterGain", CharSet = CharSet.Auto)]
        private static extern int _ReadAnalogAntiResonanceFilterGain(ref int antiResonanceFilterGain, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteAnalogAntiResonanceFilterGain", CharSet = CharSet.Auto)]
        private static extern int _WriteAnalogAntiResonanceFilterGain(int antiResonanceFilterGain, char rs485Address = (char)0, int timeOut = 50);
        // CI
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadChangeIdleCurrent", CharSet = CharSet.Auto)]
        private static extern int _ReadChangeIdleCurrent(ref double changeIdleCurrent, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteChangeIdleCurrent", CharSet = CharSet.Auto)]
        private static extern int _WriteChangeIdleCurrent(double changeIdleCurrent, char rs485Address = (char)0, int timeOut = 50);
        // CJ
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteCommenceJogging", CharSet = CharSet.Auto)]
        private static extern int _WriteCommenceJogging(char rs485Address = (char)0, int timeOut = 50);
        // CM
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadCommandMode", CharSet = CharSet.Auto)]
        private static extern int _ReadCommandMode(ref byte commandMode, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteCommandMode", CharSet = CharSet.Auto)]
        private static extern int _WriteCommandMode(byte commandMode, char rs485Address = (char)0, int timeOut = 50);
        // CP
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadChangePeakCurrent", CharSet = CharSet.Auto)]
        private static extern int _ReadChangePeakCurrent(ref double changePeakCurrent, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteChangePeakCurrent", CharSet = CharSet.Auto)]
        private static extern int _WriteChangePeakCurrent(double changePeakCurrent, char rs485Address = (char)0, int timeOut = 50);
        // CR
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteCompareRegisters", CharSet = CharSet.Auto)]
        private static extern int _WriteCompareRegisters(char register1, char register2, char rs485Address = (char)0, int timeOut = 50);
        // CS
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadChangeSpeed", CharSet = CharSet.Auto)]
        private static extern int _ReadChangeSpeed(ref double changeSpeed, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteChangeSpeed", CharSet = CharSet.Auto)]
        private static extern int _WriteChangeSpeed(double changeSpeed, char rs485Address = (char)0, int timeOut = 50);
        // CT
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteContinue", CharSet = CharSet.Auto)]
        private static extern int _WriteContinue(char rs485Address = (char)0, int timeOut = 50);
        // DA //////////
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadDefineAddress", CharSet = CharSet.Auto)]
        private static extern string _ReadDefineAddress(char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteDefineAddress", CharSet = CharSet.Auto)]
        private static extern int _WriteDefineAddress(char defineAddress, char rs485Address = (char)0, int timeOut = 50);
        // DC
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadChangeDistance", CharSet = CharSet.Auto)]
        private static extern int _ReadChangeDistance(ref int changeDistance, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteChangeDistance", CharSet = CharSet.Auto)]
        private static extern int _WriteChangeDistance(int changeDistance, char rs485Address = (char)0, int timeOut = 50);
        // DE
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadDeceleration", CharSet = CharSet.Auto)]
        private static extern int _ReadDeceleration(ref double deceleration, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteDeceleration", CharSet = CharSet.Auto)]
        private static extern int _WriteDeceleration(double deceleration, char rs485Address = (char)0, int timeOut = 50);
        // DI
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadDistance", CharSet = CharSet.Auto)]
        private static extern int _ReadDistance(ref int distance, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteDistance", CharSet = CharSet.Auto)]
        private static extern int _WriteDistance(int distance, char rs485Address = (char)0, int timeOut = 50);
        // DL
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadDefineLimits", CharSet = CharSet.Auto)]
        private static extern int _ReadDefineLimits(ref byte defineLimits, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteDefineLimits", CharSet = CharSet.Auto)]
        private static extern int _WriteDefineLimits(byte defineLimits, char rs485Address = (char)0, int timeOut = 50);
        // DR
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteDataRegisterforCapture", CharSet = CharSet.Auto)]
        private static extern int _WriteDataRegisterforCapture(char dataRegisterforCapture, char rs485Address = (char)0, int timeOut = 50);
        // ED
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadEncoderDirection", CharSet = CharSet.Auto)]
        private static extern int _ReadEncoderDirection(ref byte encoderDirection, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteEncoderDirection", CharSet = CharSet.Auto)]
        private static extern int _WriteEncoderDirection(byte encoderDirection, char rs485Address = (char)0, int timeOut = 50);
        // EF
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadEncoderFunction", CharSet = CharSet.Auto)]
        private static extern int _ReadEncoderFunction(ref byte encoderFunction, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteEncoderFunction", CharSet = CharSet.Auto)]
        private static extern int _WriteEncoderFunction(byte encoderFunction, char rs485Address = (char)0, int timeOut = 50);
        // EG
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadElectronicGearing", CharSet = CharSet.Auto)]
        private static extern int _ReadElectronicGearing(ref int electronicGearing, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteElectronicGearing", CharSet = CharSet.Auto)]
        private static extern int _WriteElectronicGearing(int electronicGearing, char rs485Address = (char)0, int timeOut = 50);
        // EI
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadEncoderFilterConstant", CharSet = CharSet.Auto)]
        private static extern int _ReadEncoderFilterConstant(ref byte encoderFilterConstant, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteEncoderFilterConstant", CharSet = CharSet.Auto)]
        private static extern int _WriteEncoderFilterConstant(byte encoderFilterConstant, char rs485Address = (char)0, int timeOut = 50);
        // EP
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadEncoderPosition", CharSet = CharSet.Auto)]
        private static extern int _ReadEncoderPosition(ref int encoderPosition, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteEncoderPosition", CharSet = CharSet.Auto)]
        private static extern int _WriteEncoderPosition(int encoderPosition, char rs485Address = (char)0, int timeOut = 50);
        // ER
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadEncoderResolution", CharSet = CharSet.Auto)]
        private static extern int _ReadEncoderResolution(ref int encoderResolution, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteEncoderResolution", CharSet = CharSet.Auto)]
        private static extern int _WriteEncoderResolution(int encoderResolution, char rs485Address = (char)0, int timeOut = 50);
        // FC
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteFeedtoLengthwithSpeedChange", CharSet = CharSet.Auto)]
        private static extern int _WriteFeedtoLengthwithSpeedChange(byte input, char inputCondition, char rs485Address = (char)0, int timeOut = 50);
        // FD
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteFeedtoDoubleSensor", CharSet = CharSet.Auto)]
        private static extern int _WriteFeedtoDoubleSensor(byte input1, char inputCondition1, byte input2, char inputCondition2, char rs485Address = (char)0, int timeOut = 50);
        // FE
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteFollowEncoder", CharSet = CharSet.Auto)]
        private static extern int _WriteFollowEncoder(byte input, bool withOptionX, char inputCondition, char rs485Address = (char)0, int timeOut = 50);
        // FI
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadFilterInput", CharSet = CharSet.Auto)]
        private static extern int _ReadFilterInput(byte input, ref int filter, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteFilterInput", CharSet = CharSet.Auto)]
        private static extern int _WriteFilterInput(byte input, int filter, char rs485Address = (char)0, int timeOut = 50);
        // FL
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadFeedtoLength", CharSet = CharSet.Auto)]
        private static extern int _ReadFeedtoLength(char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteFeedtoLength", CharSet = CharSet.Auto)]
        private static extern int _WriteFeedtoLength(int feedtoLength, char rs485Address = (char)0, int timeOut = 50);
        // FM
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteFeedtoSensorwithMaskDistance", CharSet = CharSet.Auto)]
        private static extern int _WriteFeedtoSensorwithMaskDistance(byte input, bool withOptionalX, char inputCondition, char rs485Address = (char)0, int timeOut = 50);
        // FO
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteFeedtoLengthandSetOutput", CharSet = CharSet.Auto)]
        private static extern int _WriteFeedtoLengthandSetOutput(byte output, char outputStatus, char rs485Address = (char)0, int timeOut = 50);
        // FP
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteFeedtoPosition", CharSet = CharSet.Auto)]
        private static extern int _WriteFeedtoPosition(int feedtoPosition, char rs485Address = (char)0, int timeOut = 50);
        // FS
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteFeedtoSensor", CharSet = CharSet.Auto)]
        private static extern int _WriteFeedtoSensor(int feedtoPosition, bool withOptionalX, char inputCondition, char rs485Address = (char)0, int timeOut = 50);
        // FX
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadFilterSelectInputs", CharSet = CharSet.Auto)]
        private static extern int _ReadFilterSelectInputs(ref byte filterSelectInputs, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteFilterSelectInputs", CharSet = CharSet.Auto)]
        private static extern int _WriteFilterSelectInputs(byte filterSelectInputs, char rs485Address = (char)0, int timeOut = 50);
        // FY
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteFeedtoSensorwithSafetyDistance", CharSet = CharSet.Auto)]
        private static extern int _WriteFeedtoSensorwithSafetyDistance(int input, bool withOptionalX, char inputCondition, char rs485Address = (char)0, int timeOut = 50);
        // GC
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadCurrentCommand", CharSet = CharSet.Auto)]
        private static extern int _ReadCurrentCommand(ref int currentCommand, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteCurrentCommand", CharSet = CharSet.Auto)]
        private static extern int _WriteCurrentCommand(int currentCommand, char rs485Address = (char)0, int timeOut = 50);
        // HG
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadHarmonicFilterGain", CharSet = CharSet.Auto)]
        private static extern int _ReadHarmonicFilterGain(ref int harmonicFilterGain, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteHarmonicFilterGain", CharSet = CharSet.Auto)]
        private static extern int _WriteHarmonicFilterGain(int harmonicFilterGain, char rs485Address = (char)0, int timeOut = 50);
        // HP
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadHarmonicFilterPhase", CharSet = CharSet.Auto)]
        private static extern int _ReadHarmonicFilterPhase(ref int harmonicFilterPhase, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteHarmonicFilterPhase", CharSet = CharSet.Auto)]
        private static extern int _WriteHarmonicFilterPhase(int harmonicFilterPhase, char rs485Address = (char)0, int timeOut = 50);
        // HW
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteHandWheel", CharSet = CharSet.Auto)]
        private static extern int _WriteHandWheel(int input, bool withOptionalX, char inputCondition, char rs485Address = (char)0, int timeOut = 50);
        // IA
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadImmediateAnalog", CharSet = CharSet.Auto)]
        private static extern int _ReadImmediateAnalog(ref double analog, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadImmediateAnalog2", CharSet = CharSet.Auto)]
        private static extern int _ReadImmediateAnalog2(ref double analog, int num, char rs485Address = (char)0, int timeOut = 50);
        // ID
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadImmediateDistance", CharSet = CharSet.Auto)]
        private static extern int _ReadImmediateDistance(ref int immediateDistance, char rs485Address = (char)0, int timeOut = 50);
        // IE
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadImmediateEncoder", CharSet = CharSet.Auto)]
        private static extern int _ReadImmediateEncoder(ref int immediateEncoder, char rs485Address = (char)0, int timeOut = 50);
        // IF
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadHexFormat", CharSet = CharSet.Auto)]
        private static extern int _ReadHexFormat(ref bool hexFormat, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteHexFormat", CharSet = CharSet.Auto)]
        private static extern int _WriteHexFormat(bool isHexFormat, char rs485Address = (char)0, int timeOut = 50);
        // IH
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteImmediateHighOutput", CharSet = CharSet.Auto)]
        private static extern int _WriteImmediateHighOutput(int output, bool withOptionalY, char outputCondition, char rs485Address = (char)0, int timeOut = 50);
        // IL
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteImmediateLowOutput", CharSet = CharSet.Auto)]
        private static extern int _WriteImmediateLowOutput(int output, bool withOptionalY, char outputCondition, char rs485Address = (char)0, int timeOut = 50);
        // IC
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadImmediateCurrentCommanded", CharSet = CharSet.Auto)]
        private static extern int _ReadImmediateCurrentCommanded(ref double immediateCurrentCommanded, char rs485Address = (char)0, int timeOut = 50);
        // IO
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadOutputStatus", CharSet = CharSet.Auto)]
        private static extern int _ReadOutputStatus(ref byte outputStatus, bool withOptionalY, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteOutputStatus", CharSet = CharSet.Auto)]
        private static extern int _WriteOutputStatus(byte outputStatus, bool withOptionalY, char rs485Address = (char)0, int timeOut = 50);
        // IP
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadImmediatePosition", CharSet = CharSet.Auto)]
        private static extern int _ReadImmediatePosition(ref int immediatePosition, char rs485Address = (char)0, int timeOut = 50);
        // IQ
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadImmediateCurrentActual", CharSet = CharSet.Auto)]
        private static extern int _ReadImmediateCurrentActual(ref double immediateCurrentActual, char rs485Address = (char)0, int timeOut = 50);
        // IS
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadInputStatus", CharSet = CharSet.Auto)]
        private static extern int _ReadInputStatus(ref byte inputStatus, bool withOptionalY, char rs485Address = (char)0, int timeOut = 50);
        // IT
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadImmediateTemperature", CharSet = CharSet.Auto)]
        private static extern int _ReadImmediateTemperature(ref double immediateTemperature, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadImmediateTemperature2", CharSet = CharSet.Auto)]
        private static extern int _ReadImmediateTemperature2(ref double immediateTemperature, int num, char rs485Address = (char)0, int timeOut = 50);
        // IU
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadImmediateVoltage", CharSet = CharSet.Auto)]
        private static extern int _ReadImmediateVoltage(ref double voltage, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadImmediateVoltage2", CharSet = CharSet.Auto)]
        private static extern int _ReadImmediateVoltage2(ref double voltage, int num, char rs485Address = (char)0, int timeOut = 50);
        // IV
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadImmediateActualVelocity", CharSet = CharSet.Auto)]
        private static extern int _ReadImmediateActualVelocity(ref int actualVelocity, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadImmediateTargetVelocity", CharSet = CharSet.Auto)]
        private static extern int _ReadImmediateTargetVelocity(ref int targetVelocity, char rs485Address = (char)0, int timeOut = 50);
        // IX
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadImmediatePositionError", CharSet = CharSet.Auto)]
        private static extern int _ReadImmediatePositionError(ref int immediatePositionError, char rs485Address = (char)0, int timeOut = 50);
        // JA
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadJogAcceleration", CharSet = CharSet.Auto)]
        private static extern int _ReadJogAcceleration(ref double jogAcceleration, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteJogAcceleration", CharSet = CharSet.Auto)]
        private static extern int _WriteJogAcceleration(double jogAcceleration, char rs485Address = (char)0, int timeOut = 50);
        // JC
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadVelocityModeSecondSpeed", CharSet = CharSet.Auto)]
        private static extern int _ReadVelocityModeSecondSpeed(ref double velocityModeSecondSpeed, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteVelocityModeSecondSpeed", CharSet = CharSet.Auto)]
        private static extern int _WriteVelocityModeSecondSpeed(double velocityModeSecondSpeed, char rs485Address = (char)0, int timeOut = 50);
        // JD
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteJogDisable", CharSet = CharSet.Auto)]
        private static extern int _WriteJogDisable(char rs485Address = (char)0, int timeOut = 50);
        // JE
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteJogEnable", CharSet = CharSet.Auto)]
        private static extern int _WriteJogEnable(char rs485Address = (char)0, int timeOut = 50);
        // JL
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadJogDeceleration", CharSet = CharSet.Auto)]
        private static extern int _ReadJogDeceleration(ref double jogDeceleration, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteJogDeceleration", CharSet = CharSet.Auto)]
        private static extern int _WriteJogDeceleration(double jogDeceleration, char rs485Address = (char)0, int timeOut = 50);
        // JM
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadJogMode", CharSet = CharSet.Auto)]
        private static extern int _ReadJogMode(ref byte jogMode, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteJogMode", CharSet = CharSet.Auto)]
        private static extern int _WriteJogMode(byte jogMode, char rs485Address = (char)0, int timeOut = 50);
        // JS
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadJogSpeed", CharSet = CharSet.Auto)]
        private static extern int _ReadJogSpeed(ref double jogSpeed, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteJogSpeed", CharSet = CharSet.Auto)]
        private static extern int _WriteJogSpeed(double jogSpeed, char rs485Address = (char)0, int timeOut = 50);
        // KC
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadOverallServoFilter", CharSet = CharSet.Auto)]
        private static extern int _ReadOverallServoFilter(ref int overallServoFilter, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteOverallServoFilter", CharSet = CharSet.Auto)]
        private static extern int _WriteOverallServoFilter(int overallServoFilter, char rs485Address = (char)0, int timeOut = 50);
        // KD
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadDifferentialConstant", CharSet = CharSet.Auto)]
        private static extern int _ReadDifferentialConstant(ref int differentialConstant, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteDifferentialConstant", CharSet = CharSet.Auto)]
        private static extern int _WriteDifferentialConstant(int differentialConstant, char rs485Address = (char)0, int timeOut = 50);
        // KE
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadDifferentialFilter", CharSet = CharSet.Auto)]
        private static extern int _ReadDifferentialFilter(ref int differentialFilter, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteDifferentialFilter", CharSet = CharSet.Auto)]
        private static extern int _WriteDifferentialFilter(int differentialFilter, char rs485Address = (char)0, int timeOut = 50);
        // KF - Read
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadVelocityFeedforwardConstant", CharSet = CharSet.Auto)]
        private static extern int _ReadVelocityFeedforwardConstant(ref int velocityFeedforwardConstant, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteVelocityFeedforwardConstant", CharSet = CharSet.Auto)]
        private static extern int _WriteVelocityFeedforwardConstant(int velocityFeedforwardConstant, char rs485Address = (char)0, int timeOut = 50);
        // KI
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadIntegratorConstant", CharSet = CharSet.Auto)]
        private static extern int _ReadIntegratorConstant(ref int integratorConstant, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteIntegratorConstant", CharSet = CharSet.Auto)]
        private static extern int _WriteIntegratorConstant(int integratorConstant, char rs485Address = (char)0, int timeOut = 50);
        // KJ
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadJerkFilterFrequency", CharSet = CharSet.Auto)]
        private static extern int _ReadJerkFilterFrequency(ref int jerkFilterFrequency, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteJerkFilterFrequency", CharSet = CharSet.Auto)]
        private static extern int _WriteJerkFilterFrequency(int jerkFilterFrequency, char rs485Address = (char)0, int timeOut = 50);
        // KK
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadInertiaFeedforwardConstant", CharSet = CharSet.Auto)]
        private static extern int _ReadInertiaFeedforwardConstant(ref int inertiaFeedforwardConstant, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteInertiaFeedforwardConstant", CharSet = CharSet.Auto)]
        private static extern int _WriteInertiaFeedforwardConstant(int inertiaFeedforwardConstant, char rs485Address = (char)0, int timeOut = 50);
        // KP
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadProportionalConstant", CharSet = CharSet.Auto)]
        private static extern int _ReadProportionalConstant(ref int proportionalConstant, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteProportionalConstant", CharSet = CharSet.Auto)]
        private static extern int _WriteProportionalConstant(int proportionalConstant, char rs485Address = (char)0, int timeOut = 50);
        // KV
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadVelocityFeedbackConstant", CharSet = CharSet.Auto)]
        private static extern int _ReadVelocityFeedbackConstant(ref int velocityFeedbackConstant, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteVelocityFeedbackConstant", CharSet = CharSet.Auto)]
        private static extern int _WriteVelocityFeedbackConstant(int velocityFeedbackConstant, char rs485Address = (char)0, int timeOut = 50);
        // LV
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadLowVoltageThreshold", CharSet = CharSet.Auto)]
        private static extern int _ReadLowVoltageThreshold(ref int lowVoltageThreshold, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteLowVoltageThreshold", CharSet = CharSet.Auto)]
        private static extern int _WriteLowVoltageThreshold(int lowVoltageThreshold, char rs485Address = (char)0, int timeOut = 50);
        // MD
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteMotorDisable", CharSet = CharSet.Auto)]
        private static extern int _WriteMotorDisable(char rs485Address = (char)0, int timeOut = 50);
        // ME
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteMotorEnable", CharSet = CharSet.Auto)]
        private static extern int _WriteMotorEnable(char rs485Address = (char)0, int timeOut = 50);
        // MN
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadModelNumber", CharSet = CharSet.Auto)]
        private static extern byte _ReadModelNumber(char rs485Address = (char)0, int timeOut = 50);
        // MO
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadMotionOutput", CharSet = CharSet.Auto)]
        private static extern int _ReadMotionOutput(ref byte motionOutput, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteMotionOutput", CharSet = CharSet.Auto)]
        private static extern int _WriteMotionOutput(byte motionOutput, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadMotionOutputFlexIO", CharSet = CharSet.Auto)]
        private static extern int _ReadMotionOutputFlexIO(byte output, ref byte motionOutput, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteMotionOutputFlexIO", CharSet = CharSet.Auto)]
        private static extern int _WriteMotionOutputFlexIO(byte output, byte motionOutput, char rs485Address = (char)0, int timeOut = 50);
        // MR
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadMicrostepResolution", CharSet = CharSet.Auto)]
        private static extern int _ReadMicrostepResolution(ref byte microstepResolution, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteMicrostepResolution", CharSet = CharSet.Auto)]
        private static extern int _WriteMicrostepResolution(byte microstepResolution, char rs485Address = (char)0, int timeOut = 50);
        // MT
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadMultiTasking", CharSet = CharSet.Auto)]
        private static extern int _ReadMultiTasking(ref byte multiTasking, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteMultiTasking", CharSet = CharSet.Auto)]
        private static extern int _WriteMultiTasking(byte multiTasking, char rs485Address = (char)0, int timeOut = 50);
        // MV
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadModelRevision", CharSet = CharSet.Auto)]
        private static extern string _ReadModelRevision(char rs485Address = (char)0, int timeOut = 50);
        // NO
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteNoOperation", CharSet = CharSet.Auto)]
        private static extern int _WriteNoOperation(char rs485Address = (char)0, int timeOut = 50);
        // OF
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteOnFault", CharSet = CharSet.Auto)]
        private static extern int _WriteOnFault(byte segment, char rs485Address = (char)0, int timeOut = 50);
        // OI
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteOnInput", CharSet = CharSet.Auto)]
        private static extern int _WriteOnInput(int input, bool withOptionalX, char inputCondition, char rs485Address = (char)0, int timeOut = 50);
        // OP
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadOptionBoard", CharSet = CharSet.Auto)]
        private static extern int _ReadOptionBoard(ref byte inputUsage, char rs485Address = (char)0, int timeOut = 50);
        // PA
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadPowerupAccelerationCurrent", CharSet = CharSet.Auto)]
        private static extern int _ReadPowerupAccelerationCurrent(ref double powerupAccelerationCurrent, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WritePowerupAccelerationCurrent", CharSet = CharSet.Auto)]
        private static extern int _WritePowerupAccelerationCurrent(double powerupAccelerationCurrent, char rs485Address = (char)0, int timeOut = 50);
        // PB
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadPowerupBaudRate", CharSet = CharSet.Auto)]
        private static extern int _ReadPowerupBaudRate(ref byte powerupBaudRate, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WritePowerupBaudRate", CharSet = CharSet.Auto)]
        private static extern int _WritePowerupBaudRate(byte powerupBaudRate, char rs485Address = (char)0, int timeOut = 50);
        // PC
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadPowerupCurrent", CharSet = CharSet.Auto)]
        private static extern int _ReadPowerupCurrent(ref double powerupCurrent, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WritePowerupCurrent", CharSet = CharSet.Auto)]
        private static extern int _WritePowerupCurrent(double powerupCurrent, char rs485Address = (char)0, int timeOut = 50);
        // PF
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadPositionFault", CharSet = CharSet.Auto)]
        private static extern int _ReadPositionFault(ref int positionFault, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WritePositionFault", CharSet = CharSet.Auto)]
        private static extern int _WritePositionFault(int positionFault, char rs485Address = (char)0, int timeOut = 50);
        // PI
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadPowerupIdleCurrent", CharSet = CharSet.Auto)]
        private static extern int _ReadPowerupIdleCurrent(ref double powerupIdleCurrent, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WritePowerupIdleCurrent", CharSet = CharSet.Auto)]
        private static extern int _WritePowerupIdleCurrent(double powerupIdleCurrent, char rs485Address = (char)0, int timeOut = 50);
        // PL
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadPositionLimit", CharSet = CharSet.Auto)]
        private static extern int _ReadPositionLimit(ref int positionLimit, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WritePositionLimit", CharSet = CharSet.Auto)]
        private static extern int _WritePositionLimit(int positionLimit, char rs485Address = (char)0, int timeOut = 50);
        // PM
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadPowerupMode", CharSet = CharSet.Auto)]
        private static extern int _ReadPowerupMode(ref byte powerupMode, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WritePowerupMode", CharSet = CharSet.Auto)]
        private static extern int _WritePowerupMode(byte powerupMode, char rs485Address = (char)0, int timeOut = 50);
        // PP
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadPowerupPeakCurrent", CharSet = CharSet.Auto)]
        private static extern int _ReadPowerupPeakCurrent(ref double powerupPeakCurrent, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WritePowerupPeakCurrent", CharSet = CharSet.Auto)]
        private static extern int _WritePowerupPeakCurrent(double powerupPeakCurrent, char rs485Address = (char)0, int timeOut = 50);
        // PR
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadProtocol", CharSet = CharSet.Auto)]
        private static extern int _ReadProtocol(ref byte protocol, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteProtocol", CharSet = CharSet.Auto)]
        private static extern int _WriteProtocol(byte protocol, char rs485Address = (char)0, int timeOut = 50);
        // PS
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WritePause", CharSet = CharSet.Auto)]
        private static extern int _WritePause(char rs485Address = (char)0, int timeOut = 50);
        // PW
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WritePassword", CharSet = CharSet.Auto)]
        private static extern int _WritePassword([MarshalAs(UnmanagedType.LPStr)]string password, char rs485Address = (char)0, int timeOut = 50);
        // QC
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteQueueCall", CharSet = CharSet.Auto)]
        private static extern int _WriteQueueCall(byte segment, char rs485Address = (char)0, int timeOut = 50);
        // QD
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteQueueDelete", CharSet = CharSet.Auto)]
        private static extern int _WriteQueueDelete(byte segment, char rs485Address = (char)0, int timeOut = 50);
        // QE
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteQueueExecute", CharSet = CharSet.Auto)]
        private static extern int _WriteQueueExecute(char rs485Address = (char)0, int timeOut = 50);
        // QG
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteQueueGoto", CharSet = CharSet.Auto)]
        private static extern int _WriteQueueGoto(byte lineNumber, char rs485Address = (char)0, int timeOut = 50);
        // QJ
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteQueueJump", CharSet = CharSet.Auto)]
        private static extern int _WriteQueueJump(char conditionCode, int lineNumber, char rs485Address = (char)0, int timeOut = 50);
        // QK
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteQueueKill", CharSet = CharSet.Auto)]
        private static extern int _WriteQueueKill(char rs485Address = (char)0, int timeOut = 50);
        // QL
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteQueueLoad", CharSet = CharSet.Auto)]
        private static extern int _WriteQueueLoad(bool fromNVMemory, int segment, char rs485Address = (char)0, int timeOut = 50);
        // QR
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteQueueRepeat", CharSet = CharSet.Auto)]
        private static extern int _WriteQueueRepeat(byte lineNumber, char rs485Address = (char)0, int timeOut = 50);
        // QS
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteQueueSave", CharSet = CharSet.Auto)]
        private static extern int _WriteQueueSave(byte segment, char rs485Address = (char)0, int timeOut = 50);
        // QU
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadQueueUpload", CharSet = CharSet.Auto)]
        private static extern int _ReadQueueUpload(byte segment, char rs485Address = (char)0, int timeOut = 50);
        // QX
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteQueueLoadAndExecute", CharSet = CharSet.Auto)]
        private static extern int _WriteQueueLoadAndExecute(byte segment, char rs485Address = (char)0, int timeOut = 50);
        // RC
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteRegisterCounter", CharSet = CharSet.Auto)]
        private static extern int _WriteRegisterCounter(byte input, bool withOptionalX, char inputCondition, char rs485Address = (char)0, int timeOut = 50);

        // RD
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteRegisterDecrement", CharSet = CharSet.Auto)]
        private static extern int _WriteRegisterDecrement(char dataRegister, char rs485Address = (char)0, int timeOut = 50);
        // RE
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteRestart", CharSet = CharSet.Auto)]
        private static extern int _WriteRestart(char rs485Address = (char)0, int timeOut = 50);
        // RI
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteRegisterIncrement", CharSet = CharSet.Auto)]
        private static extern int _WriteRegisterIncrement(char dataRegister, char rs485Address = (char)0, int timeOut = 50);
        // RL
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadRegisterLoad", CharSet = CharSet.Auto)]
        private static extern int _ReadRegisterLoad(char dataRegister, ref int registerValue, bool immediately, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteRegisterLoad", CharSet = CharSet.Auto)]
        private static extern int _WriteRegisterLoad(char dataRegister, int registerValue, bool immediately, char rs485Address = (char)0, int timeOut = 50);
        // RM
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteRegisterMove", CharSet = CharSet.Auto)]
        private static extern int _WriteRegisterMove(char register1, char register2, char rs485Address = (char)0, int timeOut = 50);
        // RR
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteRegisterRead", CharSet = CharSet.Auto)]
        private static extern int _WriteRegisterRead(char register1, byte register2, char rs485Address = (char)0, int timeOut = 50);
        // RS
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadRequestStatus", CharSet = CharSet.Auto)]
        private static extern string _ReadRequestStatus(char rs485Address = (char)0, int timeOut = 50);
        // RU
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteRegisterUpload", CharSet = CharSet.Auto)]
        private static extern string _WriteRegisterUpload(char dataRegister, byte number, char rs485Address = (char)0, int timeOut = 50);
        // RV
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadRevisionLevel", CharSet = CharSet.Auto)]
        private static extern int _ReadRevisionLevel(ref byte revisionLevel, char rs485Address = (char)0, int timeOut = 50);
        // RW
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteRegisterWrite", CharSet = CharSet.Auto)]
        private static extern int _WriteRegisterWrite(char register1, byte register2, char rs485Address = (char)0, int timeOut = 50);
        // R+
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteRegisterAdd", CharSet = CharSet.Auto)]
        private static extern int _WriteRegisterAdd(char register1, char register2, char rs485Address = (char)0, int timeOut = 50);
        // R-
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteRegisterSubstract", CharSet = CharSet.Auto)]
        private static extern int _WriteRegisterSubstract(char register1, char register2, char rs485Address = (char)0, int timeOut = 50);
        // R*
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteRegisterMultiply", CharSet = CharSet.Auto)]
        private static extern int _WriteRegisterMultiply(char register1, char register2, char rs485Address = (char)0, int timeOut = 50);
        // R/
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteRegisterDivide", CharSet = CharSet.Auto)]
        private static extern int _WriteRegisterDivide(char register1, char register2, char rs485Address = (char)0, int timeOut = 50);
        // R&
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteRegisterAnd", CharSet = CharSet.Auto)]
        private static extern int _WriteRegisterAnd(char register1, char register2, char rs485Address = (char)0, int timeOut = 50);
        // R|  /////////
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteRegisterOr", CharSet = CharSet.Auto)]
        private static extern int _WriteRegisterOr(char register1, char register2, char rs485Address = (char)0, int timeOut = 50);
        // SA
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteSaveParameters", CharSet = CharSet.Auto)]
        private static extern int _WriteSaveParameters(char rs485Address = (char)0, int timeOut = 50);
        // SC
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadStatusCode", CharSet = CharSet.Auto)]
        private static extern int _ReadStatusCode(ref int statusCode, char rs485Address = (char)0, int timeOut = 50);
        // SD
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadSetDirection", CharSet = CharSet.Auto)]
        private static extern int _ReadSetDirection(ref byte direction, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteSetDirection", CharSet = CharSet.Auto)]
        private static extern int _WriteSetDirection(byte input, char direction, char rs485Address = (char)0, int timeOut = 50);
        // SF
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadStepFilterFrequency", CharSet = CharSet.Auto)]
        private static extern int _ReadStepFilterFrequency(ref int filter, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteStepFilterFrequency", CharSet = CharSet.Auto)]
        private static extern int _WriteStepFilterFrequency(int filter, char rs485Address = (char)0, int timeOut = 50);
        // SH
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteSeekHome", CharSet = CharSet.Auto)]
        private static extern int _WriteSeekHome(int input, bool withOptionalX, char inputCondition, char rs485Address = (char)0, int timeOut = 50);
        // SI
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadEnableInputUsage", CharSet = CharSet.Auto)]
        private static extern int _ReadEnableInputUsage(ref byte enableInputUsage, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteEnableInputUsage", CharSet = CharSet.Auto)]
        private static extern int _WriteEnableInputUsage(byte enableInputUsage, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadEnableInputUsageFlexIO", CharSet = CharSet.Auto)]
        private static extern int _ReadEnableInputUsageFlexIO(byte input, ref byte enableInputUsage, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteEnableInputUsageFlexIO", CharSet = CharSet.Auto)]
        private static extern int _WriteEnableInputUsageFlexIO(byte input, byte enableInputUsage, char rs485Address = (char)0, int timeOut = 50);
        // SJ
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteStopJogging", CharSet = CharSet.Auto)]
        private static extern int _WriteStopJogging(char rs485Address = (char)0, int timeOut = 50);
        // SK
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteStopAndKill", CharSet = CharSet.Auto)]
        private static extern int _WriteStopAndKill(bool withOptionD, char rs485Address = (char)0, int timeOut = 50);
        // SM
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteStopMove", CharSet = CharSet.Auto)]
        private static extern int _WriteStopMove(char stopMode, char rs485Address = (char)0, int timeOut = 50);
        // SO
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteSetOutput", CharSet = CharSet.Auto)]
        private static extern int _WriteSetOutput(int output, bool withOptionalY, char outputCondition, char rs485Address = (char)0, int timeOut = 50);
        // SP
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadSetPosition", CharSet = CharSet.Auto)]
        private static extern int _ReadSetPosition(ref int setPosition, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteSetPosition", CharSet = CharSet.Auto)]
        private static extern int _WriteSetPosition(int setPosition, char rs485Address = (char)0, int timeOut = 50);
        // SS
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteSendString", CharSet = CharSet.Auto)]
        private static extern int _WriteSendString([MarshalAs(UnmanagedType.LPStr)]string sendString, char rs485Address = (char)0, int timeOut = 50);
        // ST
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteStop", CharSet = CharSet.Auto)]
        private static extern int _WriteStop(bool withOptionD, char rs485Address = (char)0, int timeOut = 50);
        // TD
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadTransmitDelay", CharSet = CharSet.Auto)]
        private static extern int _ReadTransmitDelay(ref int transmitDelay, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteTransmitDelay", CharSet = CharSet.Auto)]
        private static extern int _WriteTransmitDelay(int transmitDelay, char rs485Address = (char)0, int timeOut = 50);
        // TI
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteTestInput", CharSet = CharSet.Auto)]
        private static extern int _WriteTestInput(int input, bool withOptionalX, char inputCondition, char rs485Address = (char)0, int timeOut = 50);
        // TR
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteTestRegister", CharSet = CharSet.Auto)]
        private static extern int _WriteTestRegister(char dataRegister, int registerValue, char rs485Address = (char)0, int timeOut = 50);
        // TS
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteTimeStamp", CharSet = CharSet.Auto)]
        private static extern int _WriteTimeStamp(char rs485Address = (char)0, int timeOut = 50);
        // VC
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadVelocityChange", CharSet = CharSet.Auto)]
        private static extern int _ReadVelocityChange(ref double velocityChange, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteVelocityChange", CharSet = CharSet.Auto)]
        private static extern int _WriteVelocityChange(double velocityChange, char rs485Address = (char)0, int timeOut = 50);
        // VE
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadVelocity", CharSet = CharSet.Auto)]
        private static extern int _ReadVelocity(ref double velocity, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteVelocity", CharSet = CharSet.Auto)]
        private static extern int _WriteVelocity(double velocity, char rs485Address = (char)0, int timeOut = 50);
        // VI
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadVelocityIntegratorConstant", CharSet = CharSet.Auto)]
        private static extern int _ReadVelocityIntegratorConstant(ref int velocityIntegratorConstant, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteVelocityIntegratorConstant", CharSet = CharSet.Auto)]
        private static extern int _WriteVelocityIntegratorConstant(int velocityIntegratorConstant, char rs485Address = (char)0, int timeOut = 50);
        // VM
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadMaxVelocity", CharSet = CharSet.Auto)]
        private static extern int _ReadMaxVelocity(ref double maxVelocity, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteMaxVelocity", CharSet = CharSet.Auto)]
        private static extern int _WriteMaxVelocity(double maxVelocity, char rs485Address = (char)0, int timeOut = 50);
        // VP
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadVelocityProportionalConstant", CharSet = CharSet.Auto)]
        private static extern int _ReadVelocityProportionalConstant(ref int velocityProportionalConstant, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteVelocityProportionalConstant", CharSet = CharSet.Auto)]
        private static extern int _WriteVelocityProportionalConstant(int velocityProportionalConstant, char rs485Address = (char)0, int timeOut = 50);
        // WD //need 
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteWaitDelay", CharSet = CharSet.Auto)]
        private static extern int _WriteWaitDelay(char dataRegister, char rs485Address = (char)0, int timeOut = 50);
        // WI
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteWaitforInput", CharSet = CharSet.Auto)]
        private static extern int _WriteWaitforInput(int input, bool withOptionalX, char inputCondition, char rs485Address = (char)0, int timeOut = 50);
        // WM
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteWaitonMove", CharSet = CharSet.Auto)]
        private static extern int _WriteWaitonMove(char rs485Address = (char)0, int timeOut = 50);
        // WP
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteWaitPosition", CharSet = CharSet.Auto)]
        private static extern int _WriteWaitPosition(char rs485Address = (char)0, int timeOut = 50);
        // WT
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteWaitTime", CharSet = CharSet.Auto)]
        private static extern int _WriteWaitTime(double waitTime, char rs485Address = (char)0, int timeOut = 50);
        // ZC
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadRegenResistorContinuousWattage", CharSet = CharSet.Auto)]
        private static extern int _ReadRegenResistorContinuousWattage(ref int regenResistorContinuousWattage, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteRegenResistorContinuousWattage", CharSet = CharSet.Auto)]
        private static extern int _WriteRegenResistorContinuousWattage(int regenResistorContinuousWattage, char rs485Address = (char)0, int timeOut = 50);
        // ZR
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadRegenResistorValue", CharSet = CharSet.Auto)]
        private static extern int _ReadRegenResistorValue(ref int regenResistorValue, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteRegenResistorValue", CharSet = CharSet.Auto)]
        private static extern int _WriteRegenResistorValue(int regenResistorValue, char rs485Address = (char)0, int timeOut = 50);
        // ZT
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadRegenResistorPeakTime", CharSet = CharSet.Auto)]
        private static extern int _ReadRegenResistorPeakTime(ref int regenResistorPeakTime, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteRegenResistorPeakTime", CharSet = CharSet.Auto)]
        private static extern int _WriteRegenResistorPeakTime(int regenResistorPeakTime, char rs485Address = (char)0, int timeOut = 50);

        // HA1
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadHomingAccel1", CharSet = CharSet.Auto)]
        private static extern int _ReadHomingAccel1(ref double accel, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteHomingAccel1", CharSet = CharSet.Auto)]
        private static extern int _WriteHomingAccel1(double accel, char rs485Address = (char)0, int timeOut = 50);

        // HA2
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadHomingAccel2", CharSet = CharSet.Auto)]
        private static extern int _ReadHomingAccel2(ref double accel, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteHomingAccel2", CharSet = CharSet.Auto)]
        private static extern int _WriteHomingAccel2(double accel, char rs485Address = (char)0, int timeOut = 50);

        // HA3
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadHomingAccel3", CharSet = CharSet.Auto)]
        private static extern int _ReadHomingAccel3(ref double accel, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteHomingAccel3", CharSet = CharSet.Auto)]
        private static extern int _WriteHomingAccel3(double accel, char rs485Address = (char)0, int timeOut = 50);

        // HL1
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadHomingDecel1", CharSet = CharSet.Auto)]
        private static extern int _ReadHomingDecel1(ref double decel, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteHomingDecel1", CharSet = CharSet.Auto)]
        private static extern int _WriteHomingDecel1(double decel, char rs485Address = (char)0, int timeOut = 50);

        // HL2
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadHomingDecel2", CharSet = CharSet.Auto)]
        private static extern int _ReadHomingDecel2(ref double decel, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteHomingDecel2", CharSet = CharSet.Auto)]
        private static extern int _WriteHomingDecel2(double decel, char rs485Address = (char)0, int timeOut = 50);

        // HL3
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadHomingDecel3", CharSet = CharSet.Auto)]
        private static extern int _ReadHomingDecel3(ref double decel, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteHomingDecel3", CharSet = CharSet.Auto)]
        private static extern int _WriteHomingDecel3(double decel, char rs485Address = (char)0, int timeOut = 50);

        // HV1
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadHomingVelocity1", CharSet = CharSet.Auto)]
        private static extern int _ReadHomingVelocity1(ref double velocity, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteHomingVelocity1", CharSet = CharSet.Auto)]
        private static extern int _WriteHomingVelocity1(double velocity, char rs485Address = (char)0, int timeOut = 50);

        // HV2
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadHomingVelocity2", CharSet = CharSet.Auto)]
        private static extern int _ReadHomingVelocity2(ref double velocity, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteHomingVelocity2", CharSet = CharSet.Auto)]
        private static extern int _WriteHomingVelocity2(double velocity, char rs485Address = (char)0, int timeOut = 50);

        // HV3
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadHomingVelocity3", CharSet = CharSet.Auto)]
        private static extern int _ReadHomingVelocity3(ref double velocity, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteHomingVelocity3", CharSet = CharSet.Auto)]
        private static extern int _WriteHomingVelocity3(double velocity, char rs485Address = (char)0, int timeOut = 50);

        // HD
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "ReadDistanceAfterSensorReached", CharSet = CharSet.Auto)]
        private static extern int _ReadDistanceAfterSensorReached(ref int distance, char rs485Address = (char)0, int timeOut = 50);
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteDistanceAfterSensorReached", CharSet = CharSet.Auto)]
        private static extern int _WriteDistanceAfterSensorReached(int distance, char rs485Address = (char)0, int timeOut = 50);

        // EH
        [DllImport(@"C:\Windows\System32\MoonsCommLib.dll", EntryPoint = "WriteExtendedHoming", CharSet = CharSet.Auto)]
        private static extern int _WriteExtendedHoming(double velocity, char rs485Address = (char)0, int timeOut = 50);
        #endregion

        #region Public Methods


        public bool IsOpen
        {
            get
            {
                return _IsOpen();
            }
        }

        private int m_Port = 1;
        public int Port
        {
            get
            {
                return m_Port;
            }
            set
            {
                m_Port = value;
            }
        }
        public int OpenPort(int port, int baudRate, byte protocol, bool hexFormat)
        {
            int ret = _OpenPort(port, baudRate, protocol, hexFormat);
            return ret;
        }

        public int ClosePort()
        {
            int ret = _ClosePort();
            return ret;
        }

        ~MoonsCommLibHelper()
        {
            _ClosePort();
        }

        public int SendCommand(byte[] command, char rs485Address = (char)0)
        {
            return _SendCommand(command, rs485Address);
        }

        public int SendCommand(string command, char rs485Address = (char)0)
        {
            if (!_IsOpen())
            {
                return 100;
            }
            byte[] buf = System.Text.ASCIIEncoding.ASCII.GetBytes(command);
            int ret = SendCommand(buf, rs485Address);
            return ret;
        }

        public string ExecuteCommand(byte[] command, char rs485Address = (char)0, int timeOut = 50)
        {
            return _ExecuteCommand(command, rs485Address, timeOut);
        }

        public string ExecuteCommand(string command, char rs485Address = (char)0, int timeOut = 50)
        {
            if (!_IsOpen())
            {
                return string.Empty;
            }
            byte[] buf = System.Text.ASCIIEncoding.ASCII.GetBytes(command);
            return ExecuteCommand(buf, rs485Address, timeOut);
        }

        //AC
        public int ReadAccelerationRate(ref double accel, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadAccelerationRate(ref accel, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteAccelerationRate(double accel, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteAccelerationRate(accel, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // AD

        public int ReadAnalogDeadband(ref byte analogDeadband, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadAnalogDeadband(ref analogDeadband, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteAnalogDeadband(byte analogDeadband, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteAnalogDeadband(analogDeadband, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // AF

        public int ReadAnalogFilter(ref int analogFilter, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadAnalogFilter(ref analogFilter, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteAnalogFilter(int analogFilter, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteAnalogFilter(analogFilter, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // AG

        public int ReadAnalogVelocityGain(ref int analogVelocityGain, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadAnalogVelocityGain(ref analogVelocityGain, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteAnalogVelocityGain(int analogVelocityGain, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteAnalogVelocityGain(analogVelocityGain, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // AI			   
        public int ReadAlarmResetInput(ref byte alarmResetInput, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadAlarmResetInput(ref alarmResetInput, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteAlarmResetInput(byte alarmResetInput, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteAlarmResetInput(alarmResetInput, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int ReadAlarmResetInputFlexIO(byte input, ref byte alarmResetInput, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadAlarmResetInputFlexIO(input, ref alarmResetInput, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteAlarmResetInputFlexIO(byte input, byte alarmResetInput, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteAlarmResetInputFlexIO(input, alarmResetInput, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // AL

        public int ReadAlarmCode(ref int alarmCode, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadAlarmCode(ref alarmCode, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // AM

        public int ReadMaxAcceleration(ref double maxAcceleration, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadMaxAcceleration(ref maxAcceleration, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteMaxAcceleration(double maxAcceleration, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteMaxAcceleration(maxAcceleration, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // AN

        public int ReadAnalogTorqueGain(ref double analogTorqueGain, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadAnalogTorqueGain(ref analogTorqueGain, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteAnalogTorqueGain(double analogTorqueGain, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteAnalogTorqueGain(analogTorqueGain, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // AO

        public int ReadAlarmOutput(ref byte alarmOutput, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadAlarmOutput(ref alarmOutput, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteAlarmOutput(byte alarmOutput, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteAlarmOutput(alarmOutput, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int ReadAlarmOutputFlexIO(byte output, ref byte alarmOutput, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadAlarmOutputFlexIO(output, ref alarmOutput, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteAlarmOutputFlexIO(byte output, byte alarmOutput, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteAlarmOutputFlexIO(output, alarmOutput, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // AP
        public int ReadAnalogPositionGain(ref int positionGain, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadAnalogPositionGain(ref positionGain, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteAnalogPositionGain(int positionGain, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteAnalogPositionGain(positionGain, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // AR

        public int WriteAlarmReset(bool immediate, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteAlarmReset(immediate, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // AS

        public int ReadAnalogScaling(ref byte scaling, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadAnalogScaling(ref scaling, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteAnalogScaling(byte scaling, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteAnalogScaling(scaling, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // AT

        public int ReadAnalogThreshold(ref double analogThreshold, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadAnalogThreshold(ref analogThreshold, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteAnalogThreshold(double analogThreshold, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteAnalogThreshold(analogThreshold, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // AV

        public int ReadAnalogOffset(ref double analogOffset, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadAnalogOffset(ref analogOffset, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteAnalogOffset(double analogOffset, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteAnalogOffset(analogOffset, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // AZ

        public int WriteAnalogZero(char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteAnalogZero(rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // BO		
        public int ReadBrakeOutput(ref byte brakeOutput, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadBrakeOutput(ref brakeOutput, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteBrakeOutput(byte brakeOutput, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteBrakeOutput(brakeOutput, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int ReadBrakeOutputFlexIO(byte output, ref byte brakeOutput, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadBrakeOutputFlexIO(output, ref brakeOutput, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteBrakeOutputFlexIO(byte output, byte brakeOutput, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteBrakeOutputFlexIO(output, brakeOutput, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // BR
        public int ReadBaudRate(ref byte baudRate, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadBaudRate(ref baudRate, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteBaudRate(byte baudRate, char rs485Address = (char)0, int nTimeOut = 200)
        {
            if (IsOpen)
            {
                return _WriteBaudRate(baudRate, rs485Address, nTimeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // BD

        public int ReadBrakeDisengageDelay(ref double brakeDisengageDelay, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadBrakeDisengageDelay(ref brakeDisengageDelay, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteBrakeDisengageDelay(double brakeDisengageDelay, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteBrakeDisengageDelay(brakeDisengageDelay, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // BE

        public int ReadBrakeEngageDelay(ref double brakeEngageDelay, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadBrakeEngageDelay(ref brakeEngageDelay, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteBrakeEngageDelay(double brakeEngageDelay, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteBrakeEngageDelay(brakeEngageDelay, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // BS
        public int ReadBufferStatus(ref byte bufferStatus, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadBufferStatus(ref bufferStatus, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // CA
        public int ReadChangeAccelerationCurrent(ref double changeAccelerationCurrent, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadChangeAccelerationCurrent(ref changeAccelerationCurrent, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteChangeAccelerationCurrent(double changeAccelerationCurrent, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteChangeAccelerationCurrent(changeAccelerationCurrent, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // CC
        public int ReadChangeCurrent(ref double changeCurrent, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadChangeCurrent(ref changeCurrent, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteChangeCurrent(double changeCurrent, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteChangeCurrent(changeCurrent, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // CD
        public int ReadIdleCurrentDelayTime(ref double idleCurrentDelayTime, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadIdleCurrentDelayTime(ref idleCurrentDelayTime, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteIdleCurrentDelayTime(double idleCurrentDelayTime, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteIdleCurrentDelayTime(idleCurrentDelayTime, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // CE
        public int ReadCommunicationError(ref int communicationError, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadCommunicationError(ref communicationError, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // CF
        public int ReadAnalogAntiResonanceFilterFreq(ref int antiResonanceFilterFreq, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadAnalogAntiResonanceFilterFreq(ref antiResonanceFilterFreq, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteAnalogAntiResonanceFilterFreq(int antiResonanceFilterFreq, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteAnalogAntiResonanceFilterFreq(antiResonanceFilterFreq, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // CG
        public int ReadAnalogAntiResonanceFilterGain(ref int antiResonanceFilterGain, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadAnalogAntiResonanceFilterGain(ref antiResonanceFilterGain, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteAnalogAntiResonanceFilterGain(int antiResonanceFilterGain, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteAnalogAntiResonanceFilterGain(antiResonanceFilterGain, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // CI
        public int ReadChangeIdleCurrent(ref double changeIdleCurrent, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadChangeIdleCurrent(ref changeIdleCurrent, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteChangeIdleCurrent(double changeIdleCurrent, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteChangeIdleCurrent(changeIdleCurrent, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        //CJ
        public int WriteCommenceJogging(char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteCommenceJogging(rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // CM
        public int ReadCommandMode(ref byte commandMode, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadCommandMode(ref commandMode, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteCommandMode(byte commandMode, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteCommandMode(commandMode, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // CP
        public int ReadChangePeakCurrent(ref double changePeakCurrent, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadChangePeakCurrent(ref changePeakCurrent, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteChangePeakCurrent(double changePeakCurrent, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteChangePeakCurrent(changePeakCurrent, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // CR
        public int WriteCompareRegisters(char register1, char register2, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteCompareRegisters(register1, register2, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // CS
        public int ReadChangeSpeed(ref double changeSpeed, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadChangeSpeed(ref changeSpeed, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteChangeSpeed(double changeSpeed, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteChangeSpeed(changeSpeed, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // CT
        public int WriteContinue(char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteContinue(rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        //DA
        public string ReadDefineAddress(char rs485Address = (char)0, int timeOut = 50)
        {
            if (!IsOpen)
            {
                return string.Empty;
            }
            return _ReadDefineAddress(rs485Address, timeOut);
        }

        public int WriteDefineAddress(char da, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteDefineAddress(da, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // DC
        public int ReadChangeDistance(ref int changeDistance, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadChangeDistance(ref changeDistance, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteChangeDistance(int changeDistance, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteChangeDistance(changeDistance, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        //DE
        public int ReadDeceleration(ref double decel, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadDeceleration(ref decel, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteDeceleration(double decel, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteDeceleration(decel, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        //DI
        public int ReadDistance(ref int di, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadDistance(ref di, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteDistance(int di, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteDistance(di, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // DL
        public int ReadDefineLimits(ref byte defineLimits, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadDefineLimits(ref defineLimits, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteDefineLimits(byte defineLimits, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteDefineLimits(defineLimits, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // DR
        public int WriteDataRegisterforCapture(char dataRegisterforCapture, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteDataRegisterforCapture(dataRegisterforCapture, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // ED
        public int ReadEncoderDirection(ref byte encoderDirection, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadEncoderDirection(ref encoderDirection, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteEncoderDirection(byte encoderDirection, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteEncoderDirection(encoderDirection, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // EF
        public int ReadEncoderFunction(ref byte encoderFunction, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadEncoderFunction(ref encoderFunction, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteEncoderFunction(byte encoderFunction, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteEncoderFunction(encoderFunction, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // EG
        public int ReadElectronicGearing(ref int electronicGearing, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadElectronicGearing(ref electronicGearing, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteElectronicGearing(int electronicGearing, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteElectronicGearing(electronicGearing, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // EI
        public int ReadEncoderFilterConstant(ref byte encoderFilterConstant, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadEncoderFilterConstant(ref encoderFilterConstant, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteEncoderFilterConstant(byte encoderFilterConstant, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteEncoderFilterConstant(encoderFilterConstant, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // EP
        public int ReadEncoderPosition(ref int encoderPosition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadEncoderPosition(ref encoderPosition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteEncoderPosition(int encoderPosition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteEncoderPosition(encoderPosition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // ER
        public int ReadEncoderResolution(ref int encoderResolution, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadEncoderResolution(ref encoderResolution, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteEncoderResolution(int encoderResolution, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteEncoderResolution(encoderResolution, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // FC
        public int WriteFeedtoLengthwithSpeedChange(byte input, char inputCondition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteFeedtoLengthwithSpeedChange(input, inputCondition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // FD
        public int WriteFeedtoDoubleSensor(byte input1, char inputCondition1, byte input2, char inputCondition2, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteFeedtoDoubleSensor(input1, inputCondition1, input2, inputCondition2, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // FE
        public int WriteFollowEncoder(byte input, bool withOptionX, char inputCondition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteFollowEncoder(input, withOptionX, inputCondition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // FI
        public int ReadFilterInput(byte input, ref int filter, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadFilterInput(input, ref filter, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteFilterInput(byte input, int filter, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteFilterInput(input, filter, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        //FL
        public int ReadFeedtoLength(char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadFeedtoLength(rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteFeedtoLength(int di, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteFeedtoLength(di, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // FM
        public int WriteFeedtoSensorwithMaskDistance(byte input, bool withOptionalX, char inputCondition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteFeedtoSensorwithMaskDistance(input, withOptionalX, inputCondition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // FO
        public int WriteFeedtoLengthandSetOutput(byte output, char outputStatus, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteFeedtoLengthandSetOutput(output, outputStatus, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // FP
        public int WriteFeedtoPosition(int feedtoPosition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteFeedtoPosition(feedtoPosition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // FS
        public int WriteFeedtoSensor(int feedtoPosition, bool withOptionalX, char inputCondition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteFeedtoSensor(feedtoPosition, withOptionalX, inputCondition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // FX
        public int ReadFilterSelectInputs(ref byte filterSelectInputs, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadFilterSelectInputs(ref filterSelectInputs, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteFilterSelectInputs(byte filterSelectInputs, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteFilterSelectInputs(filterSelectInputs, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // FY
        public int WriteFeedtoSensorwithSafetyDistance(int input, bool withOptionalX, char inputCondition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteFeedtoSensorwithSafetyDistance(input, withOptionalX, inputCondition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // GC
        public int ReadCurrentCommand(ref int currentCommand, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadCurrentCommand(ref currentCommand, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteCurrentCommand(int currentCommand, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteCurrentCommand(currentCommand, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // HG
        public int ReadHarmonicFilterGain(ref int harmonicFilterGain, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadHarmonicFilterGain(ref harmonicFilterGain, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteHarmonicFilterGain(int harmonicFilterGain, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteHarmonicFilterGain(harmonicFilterGain, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // HP
        public int ReadHarmonicFilterPhase(ref int harmonicFilterPhase, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadHarmonicFilterPhase(ref harmonicFilterPhase, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteHarmonicFilterPhase(int harmonicFilterPhase, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteHarmonicFilterPhase(harmonicFilterPhase, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // HW
        public int WriteHandWheel(int input, bool withOptionalX, char inputCondition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteHandWheel(input, withOptionalX, inputCondition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // IA
        public int ReadImmediateAnalog(ref double analog, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadImmediateAnalog(ref analog, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }


        public int ReadImmediateAnalog2(ref double analog, int num, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadImmediateAnalog2(ref analog, num, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }


        // ID
        public int ReadImmediateDistance(ref int immediateDistance, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadImmediateDistance(ref immediateDistance, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // IE
        public int ReadImmediateEncoder(ref int immediateEncoder, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadImmediateEncoder(ref immediateEncoder, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // IF
        public int ReadHexFormat(ref bool hexFormat, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadHexFormat(ref hexFormat, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteHexFormat(bool isHexFormat, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteHexFormat(isHexFormat, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // IH
        public int WriteImmediateHighOutput(int output, bool withOptionalY, char outputCondition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteImmediateHighOutput(output, withOptionalY, outputCondition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // IL
        public int WriteImmediateLowOutput(int output, bool withOptionalY, char outputCondition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteImmediateLowOutput(output, withOptionalY, outputCondition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // IC
        public int ReadImmediateCurrentCommanded(ref double immediateCurrentCommanded, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadImmediateCurrentCommanded(ref immediateCurrentCommanded, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // IO
        public int ReadOutputStatus(ref byte outputStatus, bool withOptionalY, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadOutputStatus(ref outputStatus, withOptionalY, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteOutputStatus(byte outputStatus, bool withOptionalY, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteOutputStatus(outputStatus, withOptionalY, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // IP
        public int ReadImmediatePosition(ref int immediatePosition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadImmediatePosition(ref immediatePosition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // IQ
        public int ReadImmediateCurrentActual(ref double immediateCurrentActual, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadImmediateCurrentActual(ref immediateCurrentActual, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // IS
        public int ReadInputStatus(ref byte inputStatus, bool withOptionalY, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadInputStatus(ref inputStatus, withOptionalY, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // IT
        public int ReadImmediateTemperature(ref double immediateTemperature, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadImmediateTemperature(ref immediateTemperature, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int ReadImmediateTemperature2(ref double immediateTemperature, int num, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadImmediateTemperature2(ref immediateTemperature, num, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }


        // IU
        public int ReadImmediateVoltage(ref double voltage, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadImmediateVoltage(ref voltage, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int ReadImmediateVoltage2(ref double voltage, int num, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadImmediateVoltage2(ref voltage, num, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // IV
        public int ReadImmediateActualVelocity(ref int actualVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadImmediateActualVelocity(ref actualVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int ReadImmediateTargetVelocity(ref int targetVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadImmediateTargetVelocity(ref targetVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // IX
        public int ReadImmediatePositionError(ref int immediatePositionError, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadImmediatePositionError(ref immediatePositionError, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        //JA
        public int ReadJogAcceleration(ref double ja, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadJogAcceleration(ref ja, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteJogAcceleration(double ja, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteJogAcceleration(ja, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // JC
        public int ReadVelocityModeSecondSpeed(ref double velocityModeSecondSpeed, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadVelocityModeSecondSpeed(ref velocityModeSecondSpeed, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteVelocityModeSecondSpeed(double velocityModeSecondSpeed, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteVelocityModeSecondSpeed(velocityModeSecondSpeed, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // JD
        public int WriteJogDisable(char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteJogDisable(rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // JE
        public int WriteJogEnable(char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteJogEnable(rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        //JL
        public int ReadJogDeceleration(ref double JogDeceleration, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadJogDeceleration(ref JogDeceleration, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteJogDeceleration(double JogDeceleration, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteJogDeceleration(JogDeceleration, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // JM
        public int ReadJogMode(ref byte jogMode, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadJogMode(ref jogMode, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteJogMode(byte jogMode, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteJogMode(jogMode, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        //JS
        public int ReadJogSpeed(ref double jogspeed, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadJogSpeed(ref jogspeed, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteJogSpeed(double jogspeed, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteJogSpeed(jogspeed, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // KC
        public int ReadOverallServoFilter(ref int overallServoFilter, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadOverallServoFilter(ref overallServoFilter, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteOverallServoFilter(int overallServoFilter, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteOverallServoFilter(overallServoFilter, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // KD
        public int ReadDifferentialConstant(ref int differentialConstant, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadDifferentialConstant(ref differentialConstant, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteDifferentialConstant(int differentialConstant, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteDifferentialConstant(differentialConstant, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // KE
        public int ReadDifferentialFilter(ref int differentialFilter, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadDifferentialFilter(ref differentialFilter, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteDifferentialFilter(int differentialFilter, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteDifferentialFilter(differentialFilter, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // KF - Read
        public int ReadVelocityFeedforwardConstant(ref int velocityFeedforwardConstant, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadVelocityFeedforwardConstant(ref velocityFeedforwardConstant, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteVelocityFeedforwardConstant(int velocityFeedforwardConstant, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteVelocityFeedforwardConstant(velocityFeedforwardConstant, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // KI
        public int ReadIntegratorConstant(ref int integratorConstant, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadIntegratorConstant(ref integratorConstant, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteIntegratorConstant(int integratorConstant, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteIntegratorConstant(integratorConstant, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // KJ
        public int ReadJerkFilterFrequency(ref int jerkFilterFrequency, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadJerkFilterFrequency(ref jerkFilterFrequency, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteJerkFilterFrequency(int jerkFilterFrequency, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteJerkFilterFrequency(jerkFilterFrequency, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // KK
        public int ReadInertiaFeedforwardConstant(ref int inertiaFeedforwardConstant, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadInertiaFeedforwardConstant(ref inertiaFeedforwardConstant, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteInertiaFeedforwardConstant(int inertiaFeedforwardConstant, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteInertiaFeedforwardConstant(inertiaFeedforwardConstant, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // KP
        public int ReadProportionalConstant(ref int proportionalConstant, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadProportionalConstant(ref proportionalConstant, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteProportionalConstant(int proportionalConstant, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteProportionalConstant(proportionalConstant, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // KV
        public int ReadVelocityFeedbackConstant(ref int velocityFeedbackConstant, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadVelocityFeedbackConstant(ref velocityFeedbackConstant, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteVelocityFeedbackConstant(int velocityFeedbackConstant, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteVelocityFeedbackConstant(velocityFeedbackConstant, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // LV
        public int ReadLowVoltageThreshold(ref int lowVoltageThreshold, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadLowVoltageThreshold(ref lowVoltageThreshold, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteLowVoltageThreshold(int lowVoltageThreshold, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteLowVoltageThreshold(lowVoltageThreshold, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // MD
        public int WriteMotorDisable(char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteMotorDisable(rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // ME
        public int WriteMotorEnable(char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteMotorEnable(rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // MN
        public byte ReadModelNumber(char rs485Address = (char)0, int timeOut = 50)
        {
            if (!IsOpen)
            {
                return 0;
            }
            return _ReadModelNumber(rs485Address, timeOut);
        }

        // MO
        public int ReadMotionOutput(ref byte motionOutput, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadMotionOutput(ref motionOutput, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteMotionOutput(byte motionOutput, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteMotionOutput(motionOutput, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int ReadMotionOutputFlexIO(byte output, ref byte motionOutput, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadMotionOutputFlexIO(output, ref motionOutput, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteMotionOutputFlexIO(byte output, byte motionOutput, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteMotionOutputFlexIO(output, motionOutput, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // MR
        public int ReadMicrostepResolution(ref byte microstepResolution, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadMicrostepResolution(ref microstepResolution, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteMicrostepResolution(byte microstepResolution, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteMicrostepResolution(microstepResolution, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // MT
        public int ReadMultiTasking(ref byte multiTasking, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadMultiTasking(ref multiTasking, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteMultiTasking(byte multiTasking, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteMultiTasking(multiTasking, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // MV
        public string ReadModelRevision(char rs485Address = (char)0, int timeOut = 50)
        {
            if (!IsOpen)
            {
                return string.Empty;
            }
            return _ReadModelRevision(rs485Address, timeOut);
        }

        // NO
        public int WriteNoOperation(char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteNoOperation(rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // OF
        public int WriteOnFault(byte segment, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteOnFault(segment, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // OI
        public int WriteOnInput(int input, bool withOptionalX, char inputCondition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteOnInput(input, withOptionalX, inputCondition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // OP
        public int ReadOptionBoard(ref byte inputUsage, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadOptionBoard(ref inputUsage, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // PA
        public int ReadPowerupAccelerationCurrent(ref double powerupAccelerationCurrent, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadPowerupAccelerationCurrent(ref powerupAccelerationCurrent, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WritePowerupAccelerationCurrent(double powerupAccelerationCurrent, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WritePowerupAccelerationCurrent(powerupAccelerationCurrent, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // PB
        public int ReadPowerupBaudRate(ref byte powerupBaudRate, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadPowerupBaudRate(ref powerupBaudRate, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WritePowerupBaudRate(byte powerupBaudRate, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WritePowerupBaudRate(powerupBaudRate, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // PC
        public int ReadPowerupCurrent(ref double powerupCurrent, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadPowerupCurrent(ref powerupCurrent, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WritePowerupCurrent(double powerupCurrent, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WritePowerupCurrent(powerupCurrent, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // PF
        public int ReadPositionFault(ref int positionFault, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadPositionFault(ref positionFault, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WritePositionFault(int positionFault, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WritePositionFault(positionFault, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // PI
        public int ReadPowerupIdleCurrent(ref double powerupIdleCurrent, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadPowerupIdleCurrent(ref powerupIdleCurrent, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WritePowerupIdleCurrent(double powerupIdleCurrent, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WritePowerupIdleCurrent(powerupIdleCurrent, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // PL
        public int ReadPositionLimit(ref int positionLimit, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadPositionLimit(ref positionLimit, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WritePositionLimit(int positionLimit, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WritePositionLimit(positionLimit, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // PM
        public int ReadPowerupMode(ref byte powerupMode, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadPowerupMode(ref powerupMode, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WritePowerupMode(byte powerupMode, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WritePowerupMode(powerupMode, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // PP
        public int ReadPowerupPeakCurrent(ref double powerupPeakCurrent, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadPowerupPeakCurrent(ref powerupPeakCurrent, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WritePowerupPeakCurrent(double powerupPeakCurrent, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WritePowerupPeakCurrent(powerupPeakCurrent, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // PR
        public int ReadProtocol(ref byte protocol, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadProtocol(ref protocol, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteProtocol(byte protocol, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteProtocol(protocol, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // PS
        public int WritePause(char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WritePause(rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // PW
        public int WritePassword(string password, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WritePassword(password, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // QC
        public int WriteQueueCall(byte segment, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteQueueCall(segment, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // QD
        public int WriteQueueDelete(byte segment, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteQueueDelete(segment, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // QE
        public int WriteQueueExecute(char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteQueueExecute(rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // QG
        public int WriteQueueGoto(byte lineNumber, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteQueueGoto(lineNumber, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // QJ
        public int WriteQueueJump(char conditionCode, int lineNumber, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteQueueJump(conditionCode, lineNumber, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // QK
        public int WriteQueueKill(char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteQueueKill(rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // QL
        public int WriteQueueLoad(bool fromNVMemory, int segment, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteQueueLoad(fromNVMemory, segment, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // QR
        public int WriteQueueRepeat(byte lineNumber, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteQueueRepeat(lineNumber, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // QS
        public int WriteQueueSave(byte segment, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteQueueSave(segment, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // QU
        public int ReadQueueUpload(byte segment, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadQueueUpload(segment, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // QX
        public int WriteQueueLoadAndExecute(byte segment, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteQueueLoadAndExecute(segment, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // RC
        public int WriteRegisterCounter(byte input, bool withOptionalX, char inputCondition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteRegisterCounter(input, withOptionalX, inputCondition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // RD
        public int WriteRegisterDecrement(char dataRegister, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteRegisterDecrement(dataRegister, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // RE
        public int WriteRestart(char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteRestart(rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // RI
        public int WriteRegisterIncrement(char dataRegister, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteRegisterIncrement(dataRegister, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        //RL
        public int ReadRegisterLoad(char registerAddress, ref int registerValue, bool immediately, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadRegisterLoad(registerAddress, ref registerValue, immediately, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteRegisterLoad(char registerAddress, int registerValue, bool immediately, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteRegisterLoad(registerAddress, registerValue, immediately, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // RM
        public int WriteRegisterMove(char register1, char register2, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteRegisterMove(register1, register2, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // RR
        public int WriteRegisterRead(char register1, byte register2, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteRegisterRead(register1, register2, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        //RS
        public string ReadRequestStatus(char rs485Address = (char)0, int timeOut = 50)
        {
            return _ReadRequestStatus(rs485Address, timeOut);
        }

        //RU
        public string WriteRegisterUpload(char regeister, byte num, char rs485Address = (char)0, int timeOut = 100)
        {
            return _WriteRegisterUpload(regeister, num, rs485Address, timeOut);
        }

        //RV
        public int ReadRevisionLevel(ref byte revision, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadRevisionLevel(ref revision, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // RW
        public int WriteRegisterWrite(char register1, byte register2, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteRegisterWrite(register1, register2, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // R+
        public int WriteRegisterAdd(char register1, char register2, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteRegisterAdd(register1, register2, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // R-
        public int WriteRegisterSubstract(char register1, char register2, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteRegisterSubstract(register1, register2, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // R*
        public int WriteRegisterMultiply(char register1, char register2, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteRegisterMultiply(register1, register2, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // R/
        public int WriteRegisterDivide(char register1, char register2, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteRegisterDivide(register1, register2, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // R&
        public int WriteRegisterAnd(char register1, char register2, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteRegisterAnd(register1, register2, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // R|  /////////
        public int WriteRegisterOr(char register1, char register2, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteRegisterOr(register1, register2, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // SA
        public int WriteSaveParameters(char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteSaveParameters(rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // SC
        public int ReadStatusCode(ref int statusCode, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadStatusCode(ref statusCode, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // SD
        public int ReadSetDirection(ref byte direction, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadSetDirection(ref direction, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteSetDirection(byte input, char direction, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteSetDirection(input, direction, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // SF
        public int ReadStepFilterFrequency(ref int filter, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadStepFilterFrequency(ref filter, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteStepFilterFrequency(int filter, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteStepFilterFrequency(filter, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // SH
        public int WriteSeekHome(int input, bool withOptionalX, char inputCondition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteSeekHome(input, withOptionalX, inputCondition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // SI
        public int ReadEnableInputUsage(ref byte enableInputUsage, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadEnableInputUsage(ref enableInputUsage, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteEnableInputUsage(byte enableInputUsage, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteEnableInputUsage(enableInputUsage, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int ReadEnableInputUsageFlexIO(byte input, ref byte enableInputUsage, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadEnableInputUsageFlexIO(input, ref enableInputUsage, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteEnableInputUsageFlexIO(byte input, byte enableInputUsage, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteEnableInputUsageFlexIO(input, enableInputUsage, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        //SJ
        public int WriteStopJogging(char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteStopJogging(rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // SK
        public int WriteStopAndKill(bool withOptionD, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteStopAndKill(withOptionD, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // SM
        public int WriteStopMove(char stopMode, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteStopMove(stopMode, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // SO
        public int WriteSetOutput(int output, bool withOptionalY, char outputCondition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteSetOutput(output, withOptionalY, outputCondition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // SP
        public int ReadSetPosition(ref int setPosition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadSetPosition(ref setPosition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteSetPosition(int setPosition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteSetPosition(setPosition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // SS
        public int WriteSendString(string sendString, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteSendString(sendString, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // ST
        public int WriteStop(bool withOptionD, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteStop(withOptionD, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // TD
        public int ReadTransmitDelay(ref int transmitDelay, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadTransmitDelay(ref transmitDelay, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteTransmitDelay(int transmitDelay, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteTransmitDelay(transmitDelay, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // TI
        public int WriteTestInput(int input, bool withOptionalX, char inputCondition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteTestInput(input, withOptionalX, inputCondition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // TR
        public int WriteTestRegister(char dataRegister, int registerValue, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteTestRegister(dataRegister, registerValue, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // TS
        public int WriteTimeStamp(char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteTimeStamp(rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // VC
        public int ReadVelocityChange(ref double velocityChange, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadVelocityChange(ref velocityChange, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteVelocityChange(double velocityChange, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteVelocityChange(velocityChange, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        //VE
        public int ReadVelocity(ref double ve, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadVelocity(ref ve, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteVelocity(double ve, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteVelocity(ve, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // VI
        public int ReadVelocityIntegratorConstant(ref int velocityIntegratorConstant, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadVelocityIntegratorConstant(ref velocityIntegratorConstant, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteVelocityIntegratorConstant(int velocityIntegratorConstant, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteVelocityIntegratorConstant(velocityIntegratorConstant, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // VM
        public int ReadMaxVelocity(ref double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadMaxVelocity(ref maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteMaxVelocity(double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteMaxVelocity(maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // VP
        public int ReadVelocityProportionalConstant(ref int velocityProportionalConstant, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadVelocityProportionalConstant(ref velocityProportionalConstant, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteVelocityProportionalConstant(int velocityProportionalConstant, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteVelocityProportionalConstant(velocityProportionalConstant, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // WD //need 
        public int WriteWaitDelay(char dataRegister, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteWaitDelay(dataRegister, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // WI
        public int WriteWaitforInput(int input, bool withOptionalX, char inputCondition, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteWaitforInput(input, withOptionalX, inputCondition, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // WM
        public int WriteWaitonMove(char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteWaitonMove(rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // WP
        public int WriteWaitPosition(char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteWaitPosition(rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // WT
        public int WriteWaitTime(double waitTime, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteWaitTime(waitTime, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // ZC
        public int ReadRegenResistorContinuousWattage(ref int regenResistorContinuousWattage, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadRegenResistorContinuousWattage(ref regenResistorContinuousWattage, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteRegenResistorContinuousWattage(int regenResistorContinuousWattage, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteRegenResistorContinuousWattage(regenResistorContinuousWattage, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // ZR
        public int ReadRegenResistorValue(ref int regenResistorValue, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadRegenResistorValue(ref regenResistorValue, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteRegenResistorValue(int regenResistorValue, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteRegenResistorValue(regenResistorValue, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // ZT
        public int ReadRegenResistorPeakTime(ref int regenResistorPeakTime, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadRegenResistorPeakTime(ref regenResistorPeakTime, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteRegenResistorPeakTime(int regenResistorPeakTime, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteRegenResistorPeakTime(regenResistorPeakTime, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // VM
        public int ReadHomingAccel1(ref double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadHomingAccel1(ref maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteHomingAccel1(double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteHomingAccel1(maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // VM
        public int ReadHomingAccel2(ref double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadHomingAccel2(ref maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteHomingAccel2(double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteHomingAccel2(maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // VM
        public int ReadHomingAccel3(ref double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadHomingAccel3(ref maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteHomingAccel3(double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteHomingAccel3(maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }


        // VM
        public int ReadHomingDecel1(ref double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadHomingDecel1(ref maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteHomingDecel1(double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteHomingDecel1(maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // VM
        public int ReadHomingDecel2(ref double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadHomingDecel2(ref maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteHomingDecel2(double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteHomingDecel2(maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // VM
        public int ReadHomingDecel3(ref double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadHomingDecel3(ref maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteHomingDecel3(double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteHomingDecel3(maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }


        // VM
        public int ReadHomingVelocity1(ref double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadHomingVelocity1(ref maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteHomingVelocity1(double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteHomingVelocity1(maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // VM
        public int ReadHomingVelocity2(ref double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadHomingVelocity2(ref maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteHomingVelocity2(double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteHomingVelocity2(maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        // VM
        public int ReadHomingVelocity3(ref double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadHomingVelocity3(ref maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteHomingVelocity3(double maxVelocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteHomingVelocity3(maxVelocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }


        // VM
        public int ReadDistanceAfterSensorReached(ref int distance, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _ReadDistanceAfterSensorReached(ref distance, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteDistanceAfterSensorReached(int distance, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteDistanceAfterSensorReached(distance, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        public int WriteExtendedHoming(double velocity, char rs485Address = (char)0, int timeOut = 50)
        {
            if (IsOpen)
            {
                return _WriteExtendedHoming(velocity, rs485Address, timeOut);
            }
            return COMMSTATUS_OPENPORTFAILED;
        }

        #endregion
    }
}
